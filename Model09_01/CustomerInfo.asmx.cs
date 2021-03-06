﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Model09_01
{
    /// <summary>
    /// Summary description for CustomerInfo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class CustomerInfo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Customer GetCustomer(string id)
        {
            List<Customer> data = new List<Customer>
            {
                new Customer {CustomerId="123",Name="Mary" },
                new Customer {CustomerId="223",Name="Candy" },
                new Customer {CustomerId="323",Name="liy" },
            };
            Customer customer = data.Find(c => c.CustomerId == id);
            return customer;
        }

    }


    public class Customer
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
    }
}
