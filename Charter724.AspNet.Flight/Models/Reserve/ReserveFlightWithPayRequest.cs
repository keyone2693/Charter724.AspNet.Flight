using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models.Reserve
{
    public class ReserveFlightWithPayRequest : BaseModel
    {
        public int id_request { get; set; }
        public int id_faktor { get; set; }
        public int price { get; set; }
        public string redirectURL { get; set; }
    }
}
