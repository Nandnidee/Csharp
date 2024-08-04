using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];
            arr[0] = new int[3] { 1,2,3};
            arr[1] = new int[1] { 1 };
            arr[2] = new int[2] { 1, 2 };
            arr[3] = new int[4] { 1,3,5,6 };
            for(int i = 0; i < arr.Length; i++)
            {
                foreach(var val in arr[i])
                {
                    Console.Write($"{val} ");
                }
                Console.WriteLine();
            }
        }
      
    }
}
