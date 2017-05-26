using Trains.Core.DAL.Entities.Common;

namespace Trains.Core.DAL.Entities
{
    public class PassengerTrainCarEntity : TrainCarEntity
    {
        public int SeatsCount { get; set; }
        public int ReservationsCount { get; set; }
        public int AvailableSeatsCount { get; set; }
    }
}
