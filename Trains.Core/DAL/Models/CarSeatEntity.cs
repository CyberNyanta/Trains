using Trains.Core.DAL.Models.Common;

namespace Trains.Core.DAL.Models
{
    public class CarSeatEntity : BaseEntity
    {
        public string CarId { get; set; }
        public int SeatNumber { get; set; }
        public bool IsReserved { get; set; }        


    }
}