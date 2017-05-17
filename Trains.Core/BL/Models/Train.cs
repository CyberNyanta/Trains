using System;
using System.Collections.Generic;
using Trains.Core.DAL.Entities.Common;

namespace Trains.Core.BL.Models
{
    public class Train: BaseModel
    {
        public int Number { get; set; }
        public string DeparturePoint { get; set; }
        public string ArrivalePoint { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }

        public List<Car> Cars { get; set; }

    }
}