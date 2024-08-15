using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifier
{
    internal class Privateclass
    {
        Privateclass1 obj = new();
       // obj.run();
       // not able to access the run because it is private
    }
    public class Privateclass1 { 
        private void run()
        {
            Console.WriteLine("RUn");
        }
    }

}
