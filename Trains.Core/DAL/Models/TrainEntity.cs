using System;
using Trains.Core.DAL.Models.Common;

namespace Trains.Core.DAL.Models
{
    public class TrainEntity: BaseEntity
    {
        public int Number { get; set; }       
        public string DeparturePoint { get; set; }
        public string ArrivalePoint { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int CarCount { get; set; }
        public int BookingCount { get; set; }
    }
}
