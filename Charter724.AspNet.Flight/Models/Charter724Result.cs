
using System.ComponentModel;

namespace Charter724.AspNet.Flight.Models
{
    public class Charter724Result<T>
    {
        [Description("وضعیت درخواست ارسال شده")]
        public bool Status { get; set; }
        [Description("پیغام سرور به درخواست ارسال شده")]
        public string Messages { get; set; }
        [Description("نتیجه ی درخواست ارسال شده")]
        public T Result { get; set; }
    }
}
