using Trains.Core.DAL.Models.Common;

namespace Trains.Core.DAL.Models
{
    public class PassengerTrainCarEntity : TrainCarEntity
    {
        public int SeatsCount { get; set; }
        public int ReservationsCount { get; set; }
        public int AvailableSeatsCount { get; set; }
    }
}
