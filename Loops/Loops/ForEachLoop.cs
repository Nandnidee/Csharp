using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops.Loops
{
    class ForEachLoop
    {
        static public void Main()
        {
            
            string[] arr = new string[5] { "Deepika", "Rahul", "Ritik", "Nandni", "Goli" };
            foreach(string name in arr)
            {
                Console.WriteLine(name);
            }
        }

    }
}
