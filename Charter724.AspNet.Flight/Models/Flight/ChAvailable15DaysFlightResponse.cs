using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
  public  class ChAvailable15DaysFlightResponse 
    {
        public int ajency_online_ID { get; set; }
        public string type { get; set; }
        [Description("چارتر | سیستمی")]
        public string displayLable { get; set; }
        public int price_final { get; set; }
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
        public string roW_NUM2 { get; set; }
        public string linktositeallflight { get; set; }
        public int price_Markup { get; set; }
        [Description("1 = اشتراکی")]
        public int share_Sale { get; set; }
        [Description("1 = با توقف")]
        public int has_stop { get; set; }
    }
}
