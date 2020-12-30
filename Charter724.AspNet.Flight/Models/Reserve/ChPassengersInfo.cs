using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
    public class ChPassengersInfo
    {
        public string fname { get; set; }
        public string lname { get; set; }
        [Description("1:ADL  | 2:CHD | 3:INF")]
        public string type { get; set; }
        public double real_price { get; set; }
        public double fare { get; set; }
    }
}
