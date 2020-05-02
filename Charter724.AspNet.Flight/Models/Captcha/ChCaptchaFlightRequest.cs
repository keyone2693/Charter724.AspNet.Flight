using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
    public class ChCaptchaFlightRequest: BaseModel
    {
        public string from_flight { get; set; }
        public string to_flight { get; set; }
        public string date_flight { get; set; }
        public string time_flight { get; set; }
        public string number_flight { get; set; }
        public int ajency_online_ID { get; set; }
        public string cabinclass { get; set; }
        public string airline { get; set; }
    }
}
