using Trains.Core.DAL.Models.Common;

namespace Trains.Core.DAL.Models
{
    public class ReservationEntity : BaseEntity
    {
        public string CarSeatId { get; set; }
        public string UserId { get; set; }
    }
}
