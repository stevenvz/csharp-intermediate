using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L28_Abstract_Classes_and_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
