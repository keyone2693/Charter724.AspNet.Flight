using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
    public class ChPassengers
    {

        [Description("ADL | CHD | INF")]
        public string passengerType { get; set; }
        public string fnamefa { get; set; }
        public string lnamefa { get; set; }
        public string fnameen { get; set; }
        public string lnameen { get; set; }
        [Description("1 = مرد | 2 = زن")]
        public int gender { get; set; }
        [Description("1 = ir |  2 = fo")]
        public int nationality { get; set; }
        public string passengerCode { get; set; }
        public string nationalitycode { get; set; }
        public string expdate { get; set; }
        public string birthday { get; set; }
    }
}
