using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
    public class ChReserveFlightResponse
    {
        public int id_request { get; set; }
        public int id_faktor { get; set; }
        public object msg { get; set; }
        public string totalprice_request { get; set; }
        public ChPassengersInfo passenger_info { get; set; }
    }
}
