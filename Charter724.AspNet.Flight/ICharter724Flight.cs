
using Charter724.AspNet.Flight.Models;
using Charter724.AspNet.Flight.Models.Auth;
using Charter724.AspNet.Flight.Models.Flight;
using Charter724.AspNet.Flight.Models.Reserve;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Charter724.AspNet.Flight
{
    public interface ICharter724Flight
    {
        Task<Charter724Result<string>> ShowMyIP();


        Task<Charter724Result<string>> UserPassBase64Async(ChUserPassBase64Request chUserPassBase64Request);


        Task<Charter724Result<ChLoginResponse>> LoginAsync(ChLoginRequest chLoginRequest);

        Task<Charter724Result<IEnumerable<ChGetAirportsResponse>>> GetAirportsAsync(ChGetAirportsRequest chGetAirportsRequest);

        Task<Charter724Result<ChFlightAvailableResponse>> GetAvailableFlightAsync(ChAvailableFlightRequest chAvailableFlightRequest);

        Task<Charter724Result<IEnumerable<ChAvailable15DaysFlightResponse>>> GetAvailable15DaysFlightAsync(ChAvailable15DaysFlightRequest chAvailableFlightRequest);


        Task<Charter724Result<ChCaptchaFlightResponse>> GetCaptchaFlightAsync(ChCaptchaFlightRequest chCaptchaFlightRequest);

        Task<Charter724Result<ChReserveFlightResponse>> ReserveFlightAsync(ChReserveFlightRequest chReserveFlightRequest);

        Task<Charter724Result<GetChargeResponse>> GetChargeAsync();

    }
}
