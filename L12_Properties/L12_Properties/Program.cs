using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1865, 12, 6));
            Console.WriteLine(person.Age);
        }
    }
}
