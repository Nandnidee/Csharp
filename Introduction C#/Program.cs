using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(a.GetType());
            stringConverter obj = new stringConverter();
            obj.change(a);


        }
    }
}
