using System.Collections.Generic;

namespace ReversePhoneLookup.Models.Responses
{
    public class LookupResponse
    {
        public string Phone { get; set; }
        public List<string> Names { get; set; }
        public OperatorResponse Operator { get; set; }
    }
}
