using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
    public class ChReserveFlightResponse
    {
        public long id_request { get; set; }
        public long id_faktor { get; set; }
        public string msg { get; set; }
        public string duplicate { get; set; }
        public string totalprice_request { get; set; }
        public IEnumerable<ChPassengersInfo> passenger_info { get; set; }
    }
}
