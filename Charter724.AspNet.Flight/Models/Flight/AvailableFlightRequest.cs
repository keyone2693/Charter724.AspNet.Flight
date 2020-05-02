using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models.Flight
{
   public class AvailableFlightRequest : BaseModel
    {
        public string from_flight { get; set; }
        public string to_flight { get; set; }
        public string date_flight { get; set; }
    }
}
