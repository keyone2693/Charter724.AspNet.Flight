
using System.ComponentModel;

namespace Charter724.AspNet.Flight.Models
{
    internal class ServiceResult<T>
    {
        [Description("وضعیت درخواست ارسال شده")]
        internal bool result { get; set; }
        [Description("پیغام سرور به درخواست ارسال شده")]
        internal string msg { get; set; } = null;
        [Description("نتیجه ی درخواست ارسال شده")]
        internal T data { get; set; }
    }
}
