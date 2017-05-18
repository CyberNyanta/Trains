using SQLite;

namespace Trains.Core.DAL.Entities.Common
{
    public class BaseEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } = 0;
    }
}
