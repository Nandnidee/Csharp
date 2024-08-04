using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            ForLoop obj = new ForLoop();
            obj.Table7();
        }
        public void Table7()
        {
            Console.WriteLine("7 Table Using For Loop");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("7 X " + i + " = " + 7 * i);
            }
        }
    }
}
