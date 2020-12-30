using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models
{
    public class ChReserveFlightRequest : BaseModel
    {
        public long id_request { get; set; }
        public long captchcode { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public IEnumerable<ChPassengers> passengers { get; set; }
    }
}
