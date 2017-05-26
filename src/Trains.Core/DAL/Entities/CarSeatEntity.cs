using Trains.Core.BL.Models;
using Trains.Core.DAL.Entities.Common;

namespace Trains.Core.DAL.Entities
{
    public class CarSeatEntity : BaseEntity
    {
        public string CarId { get; set; }
        public int SeatNumber { get; set; }
        public bool IsReserved { get; set; }

    }
}