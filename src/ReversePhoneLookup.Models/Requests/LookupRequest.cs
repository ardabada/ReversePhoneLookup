using System.ComponentModel.DataAnnotations;

namespace ReversePhoneLookup.Models.Requests
{
    public class LookupRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone number is required")]
        public string Phone { get; set; }
    }
}
