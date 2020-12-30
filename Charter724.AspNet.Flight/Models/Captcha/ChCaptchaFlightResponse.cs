using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
    public class ChCaptchaFlightResponse
    {
        public long id_request { get; set; }
        public string link_captcha { get; set; }
        public string message { get; set; } = "";
    }
}
