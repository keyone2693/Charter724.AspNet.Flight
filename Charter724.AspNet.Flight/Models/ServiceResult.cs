
using System.ComponentModel;

namespace Charter724.AspNet.Flight.Models
{
    public class ServiceResult<T>
    {
        public string result { get; set; }
        public string msg { get; set; } = null;
        public T data { get; set; }
    }
}
