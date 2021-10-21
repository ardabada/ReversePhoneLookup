namespace ReversePhoneLookup.Abstract.Services
{
    public interface IPhoneService
    {
        string TryFormatPhoneNumber(string phone);
        bool IsPhoneNumber(string phone);
    }
}
