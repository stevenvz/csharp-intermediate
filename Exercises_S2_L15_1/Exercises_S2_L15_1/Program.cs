using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S2_L15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            //error handling behavior directed by exercise specifications - see Stopwatch.cs for details

            while (true)
            {
                Console.Write("Enter \'s\' to START, \'x\' to STOP, or \'q\' to QUIT: ");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
                else if (input == "s")
                {
                    Console.WriteLine("====================================================");
                    Console.WriteLine(stopwatch.Start());
                }
                else if (input == "x")
                {
                    Console.WriteLine();
                    Console.WriteLine("Result (HH:MM:SS.ms): " + stopwatch.Stop());
                    Console.WriteLine();
                    Console.WriteLine("====================================================");
                }
            }
        }
    }
}
