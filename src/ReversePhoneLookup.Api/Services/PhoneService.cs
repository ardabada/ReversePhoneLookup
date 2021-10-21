using System.Linq;
using ReversePhoneLookup.Abstract.Services;

namespace ReversePhoneLookup.Api.Services
{
    public class PhoneService : IPhoneService
    {
        public string TryFormatPhoneNumber(string phone)
        {
            try
            {
                phone = phone.Trim();
                if (phone[0] == '0' && phone[1] != '0')
                    return "+373" + phone.Substring(1);
                else if (phone[0] == '0' && phone[1] == '0')
                    return "+373" + phone.Substring(2);
                else if (phone.StartsWith("3730"))
                    return "+373" + phone.Substring(4);
                else if (phone.StartsWith("373"))
                    return "+" + phone;
                else if (phone.StartsWith("+3730"))
                    return "+373" + phone.Substring(5);
                else if (!phone.StartsWith("+373"))
                    return "+373" + phone;
                return phone;
            }
            catch { return phone; }
        }

        public bool IsPhoneNumber(string phone)
        {
            if (!phone.StartsWith("+373"))
                return false;
            string part = phone.Substring(4);
            if (part.Length != 8)
                return false;
            if (!part.All(x => char.IsNumber(x)))
                return false;
            string[] validPrefixes = new string[] { "60", "61", "62", "67", "68", "69", "767", "774", "775", "777", "778", "779", "78", "79" };
            foreach (var prefix in validPrefixes)
            {
                if (part.StartsWith(prefix))
                    return true;
            }
            return false;
        }
    }
}
