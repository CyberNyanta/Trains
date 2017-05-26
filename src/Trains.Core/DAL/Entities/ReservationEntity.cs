using Trains.Core.DAL.Entities.Common;

namespace Trains.Core.DAL.Entities
{
    public class ReservationEntity : BaseEntity
    {
        public string CarSeatId { get; set; }
        public string UserId { get; set; }
    }
}
