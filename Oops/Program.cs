using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    /*
     * 1. Abstraction
     * 2. Encapsulation
     * 3. Inheritance
     * 4. Polymorphism
     */
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction obj = new Abstraction();
            Console.WriteLine(obj.add(10, 20));

            Polymorphism obj2 = new Polymorphism();
            Console.WriteLine(obj2.add(10, 20,30));

            Dog obj3 = new Dog();
            Console.WriteLine("Heeloo");
            obj3.run();
            string a=Console.ReadLine()
        }
    }
}
