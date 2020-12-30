using System;
using System.Collections.Generic;
using System.Text;

namespace Charter724.AspNet.Flight.Data
{
    internal static class ApiRoutes
    {
        private const string BaseApi = Constants.ApiUrl + "/api";
        private const string BaseWebService = BaseApi + "/webservice";

        internal static class Auth
        {
            internal const string UserPassBase64 = BaseApi + "/userpassbase64";
            internal const string Login = BaseApi + "/login";
            internal const string ShowMyIP = BaseApi + "/showmyiP";

            internal const string GetCharge = BaseWebService + "/getcharge";

        }
        internal static class Flight
        {
            internal const string Airports = BaseWebService + "/airportlist";

            internal const string Available = BaseWebService + "/available";

            internal const string Available15Days = BaseWebService + "/available15days";


        }
        internal static class Ticket
        {

            internal const string Captcha = BaseWebService + "/getcaptcha";

            internal const string Reservation = BaseWebService + "/reservation";

            internal const string Buy = BaseWebService + "/buyticket";

            internal const string BuyWithPay = BaseWebService + "/payandbuyticket";

        }
    }
}
