namespace Trains.Core.BL.Models
{
    public class CarSeat
    {
        public int SeatNumber { get; set; }
       
        public bool IsReserved { get; set; } 

        public Reservation Reservation { get; set; }
    }
}