namespace ContactManager.Models.ISP
{
    public interface IOnlineOrderProcessor
    {
        bool ValidateCardInfo(CardInfo obj);
    }
}
