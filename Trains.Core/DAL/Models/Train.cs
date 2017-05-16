using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains.Core.DAL.Models
{
    public class Train
    {
        public int Number { get; set; }
        public string Destination { get; set; }        
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int CarCount { get; set; }
        public int BookingCount { get; set; }
    }
}
