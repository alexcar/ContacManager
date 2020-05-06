using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Models.ISP;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    public class ProcessOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessOrder(string paymentmode)
        {
            Customer customer = new Customer();
            Address address = new Address();
            CardInfo cardInfo = null;

            Order order = new Order();
            order.OrderId = new Random().Next(1000, 9000);
            order.Customer = customer;
            order.ShippingAddress = address;
            order.CardInfo = cardInfo;

            if (paymentmode == "card")
            {
                OnlineOrderProcessor oop = new OnlineOrderProcessor();
                cardInfo = new CardInfo();
                cardInfo.CardNo = "5555555555554444";
                cardInfo.ExpiryMonth = 12;
                cardInfo.ExpiryYear = 2020;
                order.CardInfo = cardInfo;

                oop.ValidateCardInfo(cardInfo);
                oop.ValidateShippingAddress(address);
                oop.ProcessOrder(order);
            } 
            else
            {
                CashOnDeliveryOrderProcessor codop = new CashOnDeliveryOrderProcessor();
                codop.ValidateShippingAddress(address);
                codop.ProcessOrder(order);
            }

            return View("Success", order);
        }
    }
}