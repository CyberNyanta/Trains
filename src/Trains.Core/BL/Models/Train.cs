using System;
using System.Collections.Generic;
using Trains.Core.DAL.Entities;
using Trains.Core.DAL.Entities.Common;

namespace Trains.Core.BL.Models
{
    public class Train: BaseModel
    {
        public int Number { get; set; }
        public string DeparturePoint { get; set; }
        public string ArrivalePoint { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }

        public List<Car> Cars { get; set; }


        public Train()
        {
            
        }

        public Train(TrainEntity entity)
        {
            Id = entity.Id;
            Number = entity.Number;
            DeparturePoint = entity.DeparturePoint;
            ArrivalePoint = entity.ArrivalePoint;
            ArrivalDate = entity.ArrivalDate;
            DepartureDate = entity.DepartureDate;
        }

    }
}