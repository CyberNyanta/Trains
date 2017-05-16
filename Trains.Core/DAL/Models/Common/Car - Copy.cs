using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains.Core.DAL.Models
{
    public class TrainCar
    {
        public int Id{ get; set; }
        public int SeatsCount { get; set; }
        public int ReservationsCount { get; set; }
        public int AvailableSeatsCount { get; set; }

    }
}
