using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models.Reserve
{
    public class ReserveFlightWithPayRequest : BaseModel
    {
        public long id_request { get; set; }
        public long id_faktor { get; set; }
        public double price { get; set; }
        public string redirectURL { get; set; }
    }
}
