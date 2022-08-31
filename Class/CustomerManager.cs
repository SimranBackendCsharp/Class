using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer ID: " + customer.id);
            Console.WriteLine(customer.firstname + "  " + customer.lastname);
            Console.WriteLine("-----Customer has been added!------");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.firstname + "  " + customer.lastname);
            Console.WriteLine("-----------------------");
        }
    }
}
