using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Models.OCP;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    public class TaxCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IncomeDetails obj)
        {
            ICountryTaxCalculator t = null;

            switch(obj.Country)
            {
                case "USA":
                    t = new TaxCalculatorForUS();
                    break;
                case "UK":
                    t = new TaxCalculatorForUK();
                    break;
                case "BR":
                    t = new TaxCalculatorForBR();
                    break;
            }

            t.TotalIncome = obj.TotalIncome;
            t.TotalDeduction = obj.TotalDeduction;
            TaxCalculator cal = new TaxCalculator();
            ViewBag.TotalTax = cal.Calculate(t);

            return View("Index", obj);
        }

    }
}