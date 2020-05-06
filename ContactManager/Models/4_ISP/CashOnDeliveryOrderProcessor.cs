using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Models.ISP
{
    public class CashOnDeliveryOrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(Order obj)
        {
            // do somethimg with obj
        }

        public bool ValidateShippingAddress(Address obj)
        {
            // validate shipping destination
            return true;
        }
    }
}
