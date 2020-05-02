using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
    public class ChAvailableFlightRequest : BaseModel
    {
        public bool isOneWay { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public DateTime goinDate { get; set; }
        public DateTime returnDate { get; set; }

    }
}
