using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjects
{
    class stringConverter
    {
        public void change(string inp)
        {
            int a = Convert.ToInt32(inp);
            Console.WriteLine(a.GetType());
        }
    }
}
