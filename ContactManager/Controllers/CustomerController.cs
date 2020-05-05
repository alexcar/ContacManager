using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Models.SRP;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    public class CustomerController : Controller
    {
        /*
         * ====================================
         *    Exemplo do princípio SRP
         *    Single Responsibility Principle
         * =====================================   
         * 
         * Existe uma classe específica para listar os clientes
         * Como existe uma classe específica para realizar a exportação
         * de dados dos clientes.
         */
                
        public IActionResult Index()
        {
            return View();
        }

        public List<Customer> GetData(string criteria, string searchby)
        {
            List<Customer> data = null;

            switch (searchby)
            {
                case "companyname":
                    data = CustomerSearch.SearchByCompanyName(criteria);
                    break;
                case "contactname":
                    data = CustomerSearch.SearchByContactName(criteria);
                    break;
                case "country":
                    data = CustomerSearch.SearchByCountry(criteria);
                    break;
            }

            return data;
        }

        [HttpPost]
        public IActionResult Search(string criteria, string searchby)
        {
            List<Customer> model = GetData(criteria, searchby);
            ViewBag.Criteria = criteria;
            ViewBag.SearchBy = searchby;
            
            return View(model);
        }

        [HttpPost]
        public FileResult Export(string criteria, string searchby)
        {
            List<Customer> data = GetData(criteria, searchby);
            string exportData = CustomerDataExporter.ExportToCSV(data);

            return File(System.Text.ASCIIEncoding.ASCII.GetBytes(exportData), "application/Excel");
        }

    }
}