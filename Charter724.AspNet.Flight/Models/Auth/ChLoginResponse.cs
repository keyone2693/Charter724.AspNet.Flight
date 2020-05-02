using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
   public class ChLoginResponse
    {
        public string access_token { get; set; }
        public DateTime expires_Utc { get; set; }
        public string token_type { get; set; }
    }
}
