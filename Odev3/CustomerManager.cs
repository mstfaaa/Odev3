using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev3
{
    public class CustomerManager
    {
        public List<Customer> customerList = new List<Customer>();

        public string AddCustomer(Customer addedCustomer)
        {
            customerList.Add(addedCustomer);
            return "Müşteri başarıyla eklendi.";
        }

        public string RemoveCustomer(string tckn)
        {
            customerList.RemoveAll(x => x.Tckn == tckn);
            return "Müşteri başarıyla silindi.";
        }

        public Customer GetCustomer(string tckn)
        {
            Customer c = customerList.FirstOrDefault(x => x.Tckn == tckn);
            return c;
        }

        public List<Customer> GetCustomerList()
        {
            return customerList;
        }
    }
}
