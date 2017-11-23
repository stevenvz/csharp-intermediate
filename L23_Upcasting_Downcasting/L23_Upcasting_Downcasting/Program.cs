using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L23_Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Text();
            Text text = (Text) shape;
        }
    }
}
