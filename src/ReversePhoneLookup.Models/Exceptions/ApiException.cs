using System;
using System.Collections.Generic;
using System.Text;

namespace ReversePhoneLookup.Models.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException(StatusCode code)
        {
            Code = code;
        }

        public StatusCode Code { get; }
    }
}
