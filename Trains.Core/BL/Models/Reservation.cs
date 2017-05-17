using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains.Core.BL.Models
{
    public class Reservation
    {
        public string CarSeatId { get; set; }
        public string UserId { get; set; }

        public CarSeat CarSeat { get; set; }
    }
}
