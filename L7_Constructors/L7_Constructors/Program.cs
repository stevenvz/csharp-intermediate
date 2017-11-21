using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Steve");

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            
        }
    }
}
