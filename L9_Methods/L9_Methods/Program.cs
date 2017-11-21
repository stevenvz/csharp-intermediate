using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc");

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6));
            Console.WriteLine(calculator.Add(new int[] { 55, 66, 77, 88, 99 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error has occured.");
            }
        }
    }
}
