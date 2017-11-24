using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S4_L26
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Clear();

            stack.Push(1);
            stack.Push(2);
            stack.Push("Steve");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
