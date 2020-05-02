

using Microsoft.Extensions.DependencyInjection;

namespace Charter724.AspNet.Flight.Extentions
{
   public static class Common
    {
        public static IServiceCollection AddMadpay724GateWay(this IServiceCollection services)
        {
            return services.AddScoped<ICharter724Flight, Charter724Flight>();
        }


        public static string GetErrorMessage(this int Code)
        {
            switch (Code)
            {
                case 1001:
                    return "مقدار username ارسال نشده است ";
                case 1002:
                    return "مقدار password ارسال نشده است ";
                case 1003:
                    return "نام کاربری یا کلمه عبور نادرست است ";
                case 1004:
                    return "مقدار sessionID ارسال نشده است ";
                case 1005:
                    return "مبدا ارسال نشده است ";
                case 1006:
                    return "مقصد ارسال نشده است ";
                case 1007:
                    return "مبدا و مقصد نمی تواند یکسان باشد ";
                case 1008:
                    return "تاریخ پرواز ارسال نشده است ";
                case 1009:
                    return "تاریخ پرواز نادرست است ";
                case 1010:
                    return "تاریخ پرواز منقضی شده است ";
                case 1011:
                    return "کد فرودگاه مبدا نادرست است ";
                case 1012:
                    return "کد فرودگاه مقصد نادرست است ";
                case 1013:
                    return " نادرست است sessionID";
                case 1014:
                    return "sessionID منقضی شده است ";
                case 1015:
                    return "بروز خطای نامشخص ";
                case 1016:
                    return "شناسه پرواز ارسال نشده است ";
                case 1017:
                    return "شناسه پرواز نادرست است ";
                case 1018:
                    return "کد رزرو موقت )requestID( ارسال نشده است ";
                case 1019:
                    return "کد کپچا وارد نشده است ";
                case 1020:
                    return "شماره موبایل وارد نشده است ";
                case 1021:
                    return "آدرس ایمیل وارد نشده است ";
                case 1022:
                    return "لیست اسامی مسافرین ارسال نشده است ";
                case 1023:
                    return "خطای متغییر با توجه به مشخصات رزرو ";
                case 1024:
                    return "شماره واچر ارسال نشده است ";
                case 1025:
                    return "شماره واچر صحیح نیست ";
                case 1026:
                    return "بلیط پیش از این صادر شده است ";
                case 999:
                    return "خطای وبسرویس ";
                default:
                    return "0";
            }
        }


        public static string GetErrorMessage(this string Code)
        {
            switch (Code)
            {
                case "-101":
                    return "Empty Content";
                case "-102":
                    return "Not Valid Info UserPassBase64";
                case "-103":
                    return "Login Info Not In Format";
                case "-104":
                    return "User or Pass Not Valid";
                case "-1000":
                    return "SystemError Contact To Administrator";
                case "-201":
                    return "Empty Content";
                case "-202":
                    return "Not Valid Info from_flightor.....";
                case "-203":
                    return "date Not Valid";
                case "-204":
                    return "Flight Not Found";
                case "-2000":
                    return "SystemError Contact To Administrator";
                case "-301":
                    return "Empty Content";
                case "-302":
                    return "Not Valid Infofrom_flightor .....";
                case "-303":
                    return "date Not Valid";
                case "-304":
                    return "Time Not Valid";
                case "-305":
                    return "Flight Not Found";
                case "-306":
                    return "Error Database  Request Please Contact Administrator";
                case "-3000":
                    return "SystemError Contact To Administrator";
                case "-401":
                    return "Empty Content";
                case "-402":
                    return "Not Valid Infoid_requestor .....";
                case "-403":
                    return "Email Not Valid";
                case "-404":
                    return "Mobile Not Valid";
                case "-405":
                    return "Passengers Count Not Be 0";
                case "-406":
                    return "No Validated id_request";
                case "-407":
                    return "Return CurrentReservation With This id_reques";
                case "-408":
                    return "Expierd id_request";
                case "-409":
                    return "Date Not Valid";
                case "-410":
                    return "Time Not Valid";
                case "-411":
                    return "Return  No Validated captchcode Recaptcha";
                case "-412":
                    return "Type Not Suport Just Use This Format ADL/CHD/INF";
                case "-413":
                    return "Charter Suporrt Just ADl Type";
                case "-414":
                    return "fnameen Or lnameen Not Valid";
                case "-415":
                    return "fnamefa Or lnamefa Not Valid";
                case "-416":
                    return "gender Not Valid /select=>  MR 1 /Mrs 2";
                case "-417":
                    return "nationality Not Valid Iranian 1 /Others 2";
                case "-418":
                    return "passengerCode Not Valid Just Use Alphanumeric";
                case "-419":
                    return "nationalitycode Not Valid Just Use IRQ/AFG/ARM/BHR/CHN/IND/KWT/MYS/SYR/TUR/TKM/TJK/QAT";
                case "-420":
                    return "Possport expdate Not Valid";
                case "-421":
                    return "Birthday Not Valid For ADL";
                case "-422":
                    return "Birthday Not Valid For CHD";
                case "-423":
                    return "Birthday Not Valid For INF";
                case "-424":
                    return "Birthday Not Valid";
                case "-425":
                    return "ADl Not Found";
                case "-426":
                    return "ADl and CHD less Than INF";
                case "-427":
                    return "Error Database  Request Please Contact Administrator";
                case "-428":
                    return "Error Database  Request Detail Please Contact Administrator";
                case "-429":
                    return "Charter724 Not Response";
                case "-430":
                    return "Charter724 Send Error";
                case "-4000":
                    return "SystemError Contact To Administrator";
                case "-501":
                    return "Empty Content";
                case "-502":
                    return "Not Valid Infoid_requestor ..... ";
                case "-503":
                    return "id_request Not Found";
                case "-504":
                    return "id_faktor Not Matc";
                case "-505":
                    return "Charter724 Not Response";
                case "-5000":
                    return "SystemError Contact To Administrator";
                default:
                    return "0";
            }
        }

    }
}
