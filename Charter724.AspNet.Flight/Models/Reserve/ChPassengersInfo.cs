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
        [Description("ADL  | CHD | INF")]
        public int type { get; set; }
        public int real_price { get; set; }
        public int fare { get; set; }
    }
}
