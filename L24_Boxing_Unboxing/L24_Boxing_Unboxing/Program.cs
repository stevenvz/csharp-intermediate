using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L24_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Steve");
            list.Add(DateTime.Today);

            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add("Joe");
        }
    }
}
