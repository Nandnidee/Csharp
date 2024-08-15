using System;

namespace AcessModifier
{
    /*
     * Public : accesible to everyone
     * Private : accesible to only to its class
     * Protected : only accessible to child
     * Internal : Only accessable to its assembly 
     * Protected internal : Protected + Internal
     */
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Publicclass obj = new();
            obj.run();

            Protectedclass obj1 = new();
            
        }
        public class Publicclass
        {
            
            public void run()
            {
                Console.WriteLine("Run Method");
            }
        }
    }
}