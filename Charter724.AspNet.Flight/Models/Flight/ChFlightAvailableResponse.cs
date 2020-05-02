using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Models.Flight
{
    public class ChFlightAvailableResponse
    {
        public IEnumerable<ChAvailableFlight> GoingResults { get; set; }
        public IEnumerable<ChAvailableFlight> ReturnResults { get; set; }
    }
}
