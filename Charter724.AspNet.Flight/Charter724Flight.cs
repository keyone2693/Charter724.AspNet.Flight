using Charter724.AspNet.Flight.Data;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Charter724.AspNet.Flight.Models;
using System.Collections.Generic;
using Charter724.AspNet.Flight.Extentions;
using Charter724.AspNet.Flight.Models.Flight;
using Charter724.AspNet.Flight.Models.Auth;
using Charter724.AspNet.Flight.Models.Reserve;

namespace Charter724.AspNet.Flight
{
    public class Charter724Flight : ICharter724Flight, IDisposable
    {

        #region ctor
        private readonly HttpClient _http;
        private StringContent _content;
        private HttpResponseMessage _response;

        public Charter724Flight()
        {
            _http = new HttpClient();
        }
        #endregion

        #region AsyncMethods

        public async Task<Charter724Result<string>> ShowMyIP()
        {
            _http.DefaultRequestHeaders.Clear();


            _response = await _http.GetAsync(ApiRoutes.Auth.ShowMyIP);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<string>>(await _response.Content.ReadAsStringAsync());

                if (res.result)
                {
                    return new Charter724Result<string>
                    {
                        Status = res.result,
                        Messages = null,
                        Result = res.data
                    };
                }
                else
                {
                    var err = res.msg.GetErrorMessage();
                    return new Charter724Result<string>
                    {
                        Status = false,
                        Messages = err != "0" ? err : res.msg,
                        Result = null
                    };
                }

            }
            {
                return new Charter724Result<string>
                {
                    Status = false,
                    Messages = await _response.Content.ReadAsStringAsync(),
                    Result = null
                };
            }
        }

        public async Task<Charter724Result<string>> UserPassBase64Async(ChUserPassBase64Request chUserPassBase64Request)
        {
            _http.DefaultRequestHeaders.Clear();

            _content = new StringContent(
                JsonConvert.SerializeObject(chUserPassBase64Request), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Auth.Login, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<string>>(await _response.Content.ReadAsStringAsync());

                if (res.result)
                {
                    return new Charter724Result<string>
                    {
                        Status = res.result,
                        Messages = null,
                        Result = res.data
                    };
                }
                else
                {
                    var err = res.msg.GetErrorMessage();
                    return new Charter724Result<string>
                    {
                        Status = false,
                        Messages = err != "0" ? err : res.msg,
                        Result = null
                    };
                }

            }
            {
                return new Charter724Result<string>
                {
                    Status = false,
                    Messages = await _response.Content.ReadAsStringAsync(),
                    Result = null
                };
            }
        }

        public async Task<Charter724Result<ChLoginResponse>> LoginAsync(ChLoginRequest chLoginRequest)
        {
            _http.DefaultRequestHeaders.Clear();

            _content = new StringContent(
                JsonConvert.SerializeObject(chLoginRequest), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Auth.Login, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<ChLoginResponse>>(await _response.Content.ReadAsStringAsync());

                if (res.result)
                {
                    return new Charter724Result<ChLoginResponse>
                    {
                        Status = res.result,
                        Messages = null,
                        Result = res.data
                    };
                }
                else
                {
                    var err = res.msg.GetErrorMessage();
                    return new Charter724Result<ChLoginResponse>
                    {
                        Status = false,
                        Messages = err != "0" ? err : res.msg,
                        Result = null
                    };
                }

            }
            {
                return new Charter724Result<ChLoginResponse>
                {
                    Status = false,
                    Messages = await _response.Content.ReadAsStringAsync(),
                    Result = null
                };
            }
        }

        public async Task<Charter724Result<IEnumerable<ChGetAirportsResponse>>> GetAirportsAsync(ChGetAirportsRequest chGetAirportsRequest)
        {
            _http.DefaultRequestHeaders.Clear();

            _http.DefaultRequestHeaders.Add("Authorization", Constants.PreToken + chGetAirportsRequest.Token.Trim());

            _response = await _http.GetAsync(ApiRoutes.Flight.Airports);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<IEnumerable<ChGetAirportsResponse>>>(await _response.Content.ReadAsStringAsync());
                if (res.result)
                {
                    return new Charter724Result<IEnumerable<ChGetAirportsResponse>>
                    {
                        Status = res.result,
                        Messages = null,
                        Result = res.data
                    };
                }
                else
                {
                    var err = res.msg.GetErrorMessage();
                    return new Charter724Result<IEnumerable<ChGetAirportsResponse>>
                    {
                        Status = false,
                        Messages = err != "0" ? err : res.msg,
                        Result = null
                    };
                }

            }
            {
                return new Charter724Result<IEnumerable<ChGetAirportsResponse>>
                {
                    Status = false,
                    Messages = await _response.Content.ReadAsStringAsync(),
                    Result = null
                };
            }
        }
        public async Task<Charter724Result<IEnumerable<ChAvailable15DaysFlightResponse>>> GetAvailable15DaysFlightAsync(ChAvailable15DaysFlightRequest chAvailableFlightRequest)
        {
            _http.DefaultRequestHeaders.Clear();
            _http.DefaultRequestHeaders.Add("Authorization", Constants.PreToken + chAvailableFlightRequest.Token.Trim());

            _content = new StringContent(
                JsonConvert.SerializeObject(chAvailableFlightRequest), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Flight.Available15Days, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<IEnumerable<ChAvailable15DaysFlightResponse>>>(await _response.Content.ReadAsStringAsync());
                if (res.result)
                {
                    return new Charter724Result<IEnumerable<ChAvailable15DaysFlightResponse>>
                    {
                        Status = res.result,
                        Messages = null,
                        Result = res.data
                    };
                }
                else
                {
                    var err = res.msg.GetErrorMessage();
                    return new Charter724Result<IEnumerable<ChAvailable15DaysFlightResponse>>
                    {
                        Status = false,
                        Messages = err != "0" ? err : res.msg,
                        Result = null
                    };
                }

            }
            {
                return new Charter724Result<IEnumerable<ChAvailable15DaysFlightResponse>>
                {
                    Status = false,
                    Messages = await _response.Content.ReadAsStringAsync(),
                    Result = null
                };
            }
        }

        public async Task<Charter724Result<ChFlightAvailableResponse>> GetAvailableFlightAsync(ChAvailableFlightRequest chAvailableFlightRequest)
        {
            _http.DefaultRequestHeaders.Clear();
            _http.DefaultRequestHeaders.Add("Authorization", Constants.PreToken + chAvailableFlightRequest.Token.Trim());

            var mainRes = new ChFlightAvailableResponse
            {
                GoingResults = null,
                ReturnResults = null
            };

            if (chAvailableFlightRequest.isOneWay)
            {
                var req = new AvailableFlightRequest
                {
                    from_flight = chAvailableFlightRequest.from,
                    to_flight = chAvailableFlightRequest.to,
                    date_flight = chAvailableFlightRequest.goinDate.Year + "-" +
                           chAvailableFlightRequest.goinDate.Month + "-" +
                           chAvailableFlightRequest.goinDate.Day + "-"
                };
                _content = new StringContent(
                        JsonConvert.SerializeObject(req), UTF8Encoding.UTF8, "application/json");

                _response = await _http.PostAsync(ApiRoutes.Flight.Available, _content);
                if (_response.IsSuccessStatusCode)
                {
                    var res = JsonConvert.DeserializeObject<ServiceResult<IEnumerable<ChAvailableFlight>>>(await _response.Content.ReadAsStringAsync());

                    if (res.result)
                    {
                        mainRes.GoingResults = res.data;
                        return new Charter724Result<ChFlightAvailableResponse>
                        {
                            Status = res.result,
                            Messages = null,
                            Result = mainRes
                        };
                    }
                    else
                    {
                        var err = res.msg.GetErrorMessage();
                        return new Charter724Result<ChFlightAvailableResponse>
                        {
                            Status = false,
                            Messages = err != "0" ? err : res.msg,
                            Result = null
                        };
                    }
                }
                {
                    return new Charter724Result<ChFlightAvailableResponse>
                    {
                        Status = false,
                        Messages = await _response.Content.ReadAsStringAsync(),
                        Result = null
                    };
                }
            }
            else
            {
                var req = new AvailableFlightRequest
                {
                    from_flight = chAvailableFlightRequest.from,
                    to_flight = chAvailableFlightRequest.to,
                    date_flight = chAvailableFlightRequest.goinDate.Year + "-" +
           chAvailableFlightRequest.goinDate.Month + "-" +
           chAvailableFlightRequest.goinDate.Day + "-",
                };
                _content = new StringContent(
                        JsonConvert.SerializeObject(req), UTF8Encoding.UTF8, "application/json");
                _response = await _http.PostAsync(ApiRoutes.Flight.Available, _content);
                if (_response.IsSuccessStatusCode)
                {
                    var res = JsonConvert.DeserializeObject<ServiceResult<IEnumerable<ChAvailableFlight>>>(await _response.Content.ReadAsStringAsync());
                    if (res.result)
                    {
                        mainRes.GoingResults = res.data;

                        _http.DefaultRequestHeaders.Clear();
                        var reqReturn = new AvailableFlightRequest
                        {
                            from_flight = chAvailableFlightRequest.from,
                            to_flight = chAvailableFlightRequest.to,
                            date_flight = chAvailableFlightRequest.returnDate.Year + "-" +
                                   chAvailableFlightRequest.returnDate.Month + "-" +
                                   chAvailableFlightRequest.returnDate.Day + "-",
                        };
                        _content = new StringContent(
                                JsonConvert.SerializeObject(reqReturn), UTF8Encoding.UTF8, "application/json");

                        _response = await _http.PostAsync(ApiRoutes.Flight.Available, _content);
                        if (_response.IsSuccessStatusCode)
                        {
                            var resReturn = JsonConvert.DeserializeObject<ServiceResult<IEnumerable<ChAvailableFlight>>>(await _response.Content.ReadAsStringAsync());

                            if (resReturn.result)
                            {
                                mainRes.GoingResults = resReturn.data;

                                return new Charter724Result<ChFlightAvailableResponse>
                                {
                                    Status = res.result,
                                    Messages = null,
                                    Result = mainRes
                                };
                            }
                            else
                            {
                                var err = resReturn.msg.GetErrorMessage();
                                return new Charter724Result<ChFlightAvailableResponse>
                                {
                                    Status = false,
                                    Messages = err != "0" ? err : resReturn.msg,
                                    Result = null
                                };
                            }
                        }
                        {
                            return new Charter724Result<ChFlightAvailableResponse>
                            {
                                Status = false,
                                Messages = await _response.Content.ReadAsStringAsync(),
                                Result = null
                            };
                        }
                    }
                    else
                    {
                        var err = res.msg.GetErrorMessage();
                        return new Charter724Result<ChFlightAvailableResponse>
                        {
                            Status = false,
                            Messages = err != "0" ? err : res.msg,
                            Result = mainRes
                        };
                    }
                }
                {
                    return new Charter724Result<ChFlightAvailableResponse>
                    {
                        Status = false,
                        Messages = await _response.Content.ReadAsStringAsync(),
                        Result = mainRes
                    };
                }


            }



        }

        public async Task<Charter724Result<ChCaptchaFlightResponse>> GetCaptchaFlightAsync(ChCaptchaFlightRequest chCaptchaFlightRequest)
        {
            _http.DefaultRequestHeaders.Clear();
            _http.DefaultRequestHeaders.Add("Authorization", Constants.PreToken + chCaptchaFlightRequest.Token.Trim());

            _content = new StringContent(
                JsonConvert.SerializeObject(chCaptchaFlightRequest), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Ticket.Captcha, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<ChCaptchaFlightResponse>>(await _response.Content.ReadAsStringAsync());
                if (res.result)
                {
                    return new Charter724Result<ChCaptchaFlightResponse>
                    {
                        Status = res.result,
                        Messages = null,
                        Result = res.data
                    };
                }
                else
                {
                    var err = res.msg.GetErrorMessage();
                    return new Charter724Result<ChCaptchaFlightResponse>
                    {
                        Status = false,
                        Messages = err != "0" ? err : res.msg,
                        Result = null
                    };
                }

            }
            {
                return new Charter724Result<ChCaptchaFlightResponse>
                {
                    Status = false,
                    Messages = await _response.Content.ReadAsStringAsync(),
                    Result = null
                };
            }
        }

        public async Task<Charter724Result<ChReserveFlightResponse>> ReserveFlightAsync(ChReserveFlightRequest chReserveFlightRequest)
        {
            _http.DefaultRequestHeaders.Clear();
            _http.DefaultRequestHeaders.Add("Authorization", Constants.PreToken + chReserveFlightRequest.Token.Trim());

            _content = new StringContent(
                JsonConvert.SerializeObject(chReserveFlightRequest), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Ticket.Reservation, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<ChReserveFlightResponse>>(await _response.Content.ReadAsStringAsync());
                if (res.result)
                {
                    return new Charter724Result<ChReserveFlightResponse>
                    {
                        Status = res.result,
                        Messages = null,
                        Result = res.data
                    };
                }
                else
                {
                    var err = res.msg.GetErrorMessage();
                    return new Charter724Result<ChReserveFlightResponse>
                    {
                        Status = false,
                        Messages = err != "0" ? err : res.msg,
                        Result = null
                    };
                }

            }
            {
                return new Charter724Result<ChReserveFlightResponse>
                {
                    Status = false,
                    Messages = await _response.Content.ReadAsStringAsync(),
                    Result = null
                };
            }
        }

        public async Task<Charter724Result<ChBuyTicketResponse>> BuyTicketAsync(ChBuyTicketRequest chBuyTicketRequest)
        {
            _http.DefaultRequestHeaders.Clear();
            _http.DefaultRequestHeaders.Add("Authorization", Constants.PreToken + chBuyTicketRequest.Token.Trim());

            _content = new StringContent(
                JsonConvert.SerializeObject(chBuyTicketRequest), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Ticket.Buy, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<ChBuyTicketResponse>>(await _response.Content.ReadAsStringAsync());
                if (res.result)
                {
                    return new Charter724Result<ChBuyTicketResponse>
                    {
                        Status = res.result,
                        Messages = null,
                        Result = res.data
                    };
                }
                else
                {
                    var err = res.msg.GetErrorMessage();
                    return new Charter724Result<ChBuyTicketResponse>
                    {
                        Status = false,
                        Messages = err != "0" ? err : res.msg,
                        Result = null
                    };
                }

            }
            {
                return new Charter724Result<ChBuyTicketResponse>
                {
                    Status = false,
                    Messages = await _response.Content.ReadAsStringAsync(),
                    Result = null
                };
            }
        }

        public async Task<Charter724Result<GetChargeResponse>> GetChargeAsync( )
        {
            _http.DefaultRequestHeaders.Clear();

            _response = await _http.GetAsync(ApiRoutes.Auth.GetCharge);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<GetChargeResponse>>(await _response.Content.ReadAsStringAsync());
                if (res.result)
                {
                    return new Charter724Result<GetChargeResponse>
                    {
                        Status = res.result,
                        Messages = null,
                        Result = res.data
                    };
                }
                else
                {
                    var err = res.msg.GetErrorMessage();
                    return new Charter724Result<GetChargeResponse>
                    {
                        Status = false,
                        Messages = err != "0" ? err : res.msg,
                        Result = null
                    };
                }

            }
            {
                return new Charter724Result<GetChargeResponse>
                {
                    Status = false,
                    Messages = await _response.Content.ReadAsStringAsync(),
                    Result = null
                };
            }
        }

        #endregion

        #region Dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _http.Dispose();
                    if (_content != null)
                        _content.Dispose();
                    if (_response != null)
                        _response.Dispose();
                    //
                    disposed = true;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        ~Charter724Flight()
        {
            Dispose(true);
        }
        #endregion

    }
}
