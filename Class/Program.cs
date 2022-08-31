using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.id = 648;
            customer1.firstname = "Jemy";
            customer1.lastname = "Vardy";

            Customer customer2 = new Customer();
            customer2.id = 649;
            customer2.firstname = "Nick";
            customer2.lastname = "Border";

            Customer customer3 = new Customer();
            customer3.id = 650;
            customer3.firstname = "Coby";
            customer3.lastname = "Sam";
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n-----Customer has been listed!------");
            customerManager.List(customer1);
            customerManager.List(customer2);
            customerManager.List(customer3);
        }
    }
}
