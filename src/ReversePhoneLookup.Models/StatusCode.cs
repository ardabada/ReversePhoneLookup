using System;
using System.Collections.Generic;
using System.Text;

namespace ReversePhoneLookup.Models
{
    public enum StatusCode
    {
        RequestError = 1,
        ServerError = 2,
        InvalidPhoneNumber = 10,
        NoDataFound = 11
    }
}
