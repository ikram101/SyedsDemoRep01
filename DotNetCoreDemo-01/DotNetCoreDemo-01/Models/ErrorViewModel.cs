using System;

namespace MyCoreDemo.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        //public bool ShowRequestId()
        //{
        //    return !string.IsNullOrEmpty(RequestId);
        //}
    }
}