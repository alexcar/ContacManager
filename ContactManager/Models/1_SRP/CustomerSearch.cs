﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Models.SRP
{
    public class CustomerSearch
    {
        public static List<Customer> SearchByCountry(string country)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var query = from c in db.Customers
                            where c.Country.Contains(country)
                            orderby c.CustomerId ascending
                            select c;

                return query.ToList();
            }
        }

        public static List<Customer> SearchByCompanyName(string company)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var query = from c in db.Customers
                            where c.CompanyName.Contains(company)
                            orderby c.CustomerId ascending
                            select c;

                return query.ToList();
            }
        }

        public static List<Customer> SearchByContactName(string contact)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var query = from c in db.Customers
                            where c.ContactName.Contains(contact)
                            orderby c.CustomerId ascending
                            select c;

                return query.ToList();
            }
        }
    }
}
