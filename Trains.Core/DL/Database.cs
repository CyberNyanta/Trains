using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using Trains.Core.BL.Models;
using Trains.Core.DAL.Entities;
using Trains.Core.DAL.Entities.Common;

namespace Trains.Core.DL
{
    public class Database : SQLiteConnection
    {

        private static object locker = new object();

        public Database(string path) : base(path)
        {                                    
            CreateTable<CarSeatEntity>();
            CreateTable<ReservationEntity>();
            CreateTable<PassengerTrainCarEntity>();
            CreateTable<TrainEntity>();
            CreateTable<UserEntity>();
        }
        

        public IEnumerable<T> GetItems<T>() where T : BaseEntity, new ()
        {
            lock (locker)
            {
                return (from i in Table<T>() select i).ToList();
            }
        }

        public IEnumerable<T> FindAll<T>(Func<T, bool> predicate) where T : BaseEntity, new()
        {
            lock (locker)
            {
                return Table<T>().Where<T>(predicate);              
            }
        }
        public T GetItem<T>(int id) where T : BaseEntity, new()
        {
            lock (locker)
            {                
                return Table<T>().First<T>(x => x.Id == id);
            }
        }

        public int SaveItem<T>(T item) where T : BaseEntity
        {
            lock (locker)
            {
                if (item.Id != 0)
                {
                    Update(item);
                    return item.Id;
                }
                else
                {
                    return Insert(item);
                }
            }
        }

        public int DeleteItem<T>(int id) where T : BaseEntity, new()
        {
            lock (locker)
            {              
                return Delete<T>( id );
            }
        }

        public int DeleteItem<T>(T item) where T : BaseEntity
        {            
            return DeleteItem(item);         
        }

        /// <summary>
        /// Delete every object from Table that fits the condition of predicate.
        /// </summary>
        /// <param name="predicate">
        /// Condition for items that need to be removed.
        /// </param>
        /// <returns>
        /// Count of deleted items
        /// </returns>
        /// <exception cref="Exception">Thrown when delete transaction failed</exception>
        public int DeleteGroupBy<T>(Func<T,bool> predicate) where T : BaseEntity, new()
        {
            lock (locker)
            {
                var count = 0;
                BeginTransaction();   
                     
                try
                {
                    var listOfItems = FindAll<T>(predicate).ToList();
                    for (int i = 0; i < listOfItems.Count; i++, count++)
                    {
                        Delete(listOfItems[i]);
                    }

                    Commit();

                    return count;
                }
                catch (Exception ex)
                {                    
                    Rollback();
                    throw;
                }
            }
        }

        public int DeleteGroup<T>(IList<T> group) where T : BaseEntity, new()
        {
            lock (locker)
            {
                var count = 0;
                BeginTransaction();

                try
                {
                    for (int i = 0; i < group.Count; i++, count++)
                    {
                        Delete(group[i]);
                    }

                    Commit();

                    return count;
                }
                catch (Exception ex)
                {
                    Rollback();
                    throw;
                }
            }
        }
    }
}
