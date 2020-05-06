namespace ContactManager.Models.ISP
{
    public class OnlineOrderProcessor : IOrderProcessor, IOnlineOrderProcessor
    {
        public void ProcessOrder(Order obj)
        {
            // do somethimg with obj
        }

        public bool ValidateCardInfo(CardInfo obj)
        {
            // validate credit card information
            return true;
        }

        public bool ValidateShippingAddress(Address obj)
        {
            // validate shipping destination
            return true;
        }
    }
}
