using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{

    public class ChAvailableFlight
    {
        public int ajency_online_ID { get; set; }
        public string type { get; set; }
        public string displayLable { get; set; }
        public double price_final { get; set; }
        public double price_final_chd { get; set; }
        public double price_final_inf { get; set; }
        public double price_final_fare { get; set; }
        public double price_final_chd_fare { get; set; }
        public double price_final_inf_fare { get; set; }
        public int capacity { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string number_flight { get; set; }
        [Description("Business | Economy")]
        public string type_flight { get; set; }
        public string carrier { get; set; }
        public string date_flight { get; set; }
        public string time_flight { get; set; }
        public string airline { get; set; }
        public string iatA_code { get; set; }
        public string cabinclass { get; set; }
        [Description("YES | NO")]
        public string weelchairsupport { get; set; }
        public string linktosite { get; set; }
        public double price_Markup { get; set; }
        [Description("1 = اشتراکی")]
        public double share_Sale { get; set; }
        [Description("1 = با توقف")]
        public int has_stop { get; set; }
        public string alarm_msg { get; set; }
    }
}
