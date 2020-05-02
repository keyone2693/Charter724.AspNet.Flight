using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
    public class ChBuyTicketRequest : BaseModel
    {
        public int id_request { get; set; }
        public int id_faktor { get; set; }
    }
}
