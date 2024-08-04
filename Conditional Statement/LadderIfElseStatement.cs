using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement
{
    class LadderIfElseStatement
    {
        /*
         * If number is less than 10 , Print "Less than 10".
         * If number is betweern 10 and 20 , Print "Betweeen 10 and 20".
         * Else, Print "Excede limit".
         */
        public void property(int num)
        {
            if (num < 10)
            {
                Console.WriteLine("Less Than 10");
            }else if (num >= 10 && num <= 20)
            {
                Console.WriteLine("Between 10 and 20");
            }
            else
            {
                Console.WriteLine("Excede limit");
            }

        }
    }
}
