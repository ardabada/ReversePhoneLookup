using System;
using System.Collections.Generic;
using System.Text;

namespace ReversePhoneLookup.Models.Responses
{
    public class ErrorResponse
    {
        public StatusCode Code { get; set; }
        public string Message { get; set; }
    }
}
