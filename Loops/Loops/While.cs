using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class While
    {
        static void Main(string[] args)
        {
            While obj = new While();
            obj.Table7();
        }
        public void Table7()
        {
            Console.WriteLine("7 Table Using While Loop");
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("7 X " + i + " = " + 7 * i);
                i++;
            }
        }
    }
}
