using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePhoneLookup.Api.Models.Entities
{
    public partial class Operator
    {
        public Operator()
        {
            Phones = new HashSet<Phone>();
        }

        public int Id { get; set; }
        public string Mcc { get; set; }
        public string Mnc { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
    }
}
