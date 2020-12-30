using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models.Ticket
{
   public class SavePdfRequest
    {
        public string UserId { get; set; }
        public long FactorId { get; set; }
        public string Perifix { get; set; }
        public string Url { get; set; }
        public string SavePath { get; set; }

    }
}
