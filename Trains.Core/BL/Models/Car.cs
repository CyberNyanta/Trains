using System.Collections.Generic;

namespace Trains.Core.BL.Models
{
    public class Car: BaseModel
    {
        public int SeatsCount { get; set; }
        public int ReservationsCount { get; set; }
        public int AvailableSeatsCount { get; set; }

        public List<Car> Cars { get; set; }
    }
}