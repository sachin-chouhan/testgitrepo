using System;

namespace testgit.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public int MyProperty { get; set; }
        public string MyProperty3 { get; set; }
    }
}