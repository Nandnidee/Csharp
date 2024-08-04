using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());

            //IfStatement obj = new IfStatement();
            //obj.isAllowedVoting(age);

            //IfElseStatement obj = new IfElseStatement();
            //obj.voting(age);

            LadderIfElseStatement obj = new LadderIfElseStatement();
            obj.property(age);

        }
    }
}
