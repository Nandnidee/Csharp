﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement
{
    class IfStatement
    {
        public void isAllowedVoting(int age)
        {
            if(age>=18 && age <= 120 && age is int)
            {
                Console.WriteLine(age + " age is Allowed To vote");
            }
           
        }

    }
}
