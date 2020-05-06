namespace ContactManager.Models.ISP
{
    public interface IOrderProcessor
    {
        bool ValidateShippingAddress(Address obj);
        void ProcessOrder(Order obj);
    }
}
