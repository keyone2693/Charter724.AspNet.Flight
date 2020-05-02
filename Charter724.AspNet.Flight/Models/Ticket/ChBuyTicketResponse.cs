using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
    public class ChBuyTicketResponse
    {
        public int id_request { get; set; }
        public int id_faktor { get; set; }
        public string msg { get; set; }
        public string pnrid_request { get; set; }
        public string linkticket { get; set; }
    }
}
