using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops.Loops
{
   
    class DoWhileLoop
    {
        static public void Main()
        {
            DoWhileLoop obj = new DoWhileLoop();
            obj.calculate();
        }
        public void calculate()
        {
            int a = 0;
            do
            {
                Console.WriteLine("Choose :\n1. Addition\n2. Substraction\n3. Multiplication\n4.Division");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First Number");
                decimal n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                decimal n2 = Convert.ToDecimal(Console.ReadLine());
                switch (key) {
                    case 1:
                        Console.WriteLine("Addition of " + n1 + " and " + n2 + " is " + (n1 + n2));
                       
                        break;
                    case 2:
                        Console.WriteLine("Substraction of " + n1 + " and " + n2 + " is " + (n1 - n2));
                       
                        break;
                    case 3:
                        Console.WriteLine("Multiplication of " + n1 + " and " + n2 + " is " + (n1 * n2));
                        
                        break;
                    case 4:
                        Console.WriteLine("Division of " + n1 + " and " + n2 + " is " + (n1 / n2));
                        
                        break;
                    default:
                        Console.WriteLine("Invalid Number");
                        
                        break;
                }
                Console.WriteLine("Enter 0 to Continue....");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a==0);
        }

    }
}
