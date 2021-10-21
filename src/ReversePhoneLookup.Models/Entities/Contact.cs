using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePhoneLookup.Api.Models.Entities
{
    public partial class Contact
    {
        public int Id { get; set; }
        public int PhoneId { get; set; }
        public string Name { get; set; }

        public virtual Phone Phone { get; set; }
    }
}
