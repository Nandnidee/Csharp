using AcessModifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifier
{
    public class Parent
    {
       protected void med()
        {
            Console.WriteLine("parent");
        }
    }

public class Protectedclass:Parent
    {
         static void Main(String[] args)
        {
            Console.WriteLine("Parent class");
            Protectedclass pc = new Protectedclass();
            pc.Run();
            pc.med();
        }
        protected void Run()
        {
            Console.WriteLine("Running");
        }
    }
    public class Child:Protectedclass
    {
        public void childmethod()
        {
            Run();
        }
    }
}
