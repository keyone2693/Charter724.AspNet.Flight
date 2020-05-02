using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models.Auth
{
    public class GetChargeResponse
    {
        public string msg { get; set; }
        public int parent_charge { get; set; }
        public int child_charge { get; set; }
    }
}
