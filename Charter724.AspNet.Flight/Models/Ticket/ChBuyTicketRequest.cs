using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
    public class ChBuyTicketRequest : BaseModel
    {
        public long id_request { get; set; }
        public long id_faktor { get; set; }
    }
}
