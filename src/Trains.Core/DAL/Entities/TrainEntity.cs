using System;
using Trains.Core.DAL.Entities.Common;

namespace Trains.Core.DAL.Entities
{
    public class TrainEntity: BaseEntity
    {
        public int Number { get; set; }       
        public string DeparturePoint { get; set; }
        public string ArrivalePoint { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}
