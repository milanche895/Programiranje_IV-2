using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = { 3, 12, 22, 33, 14, 45, 5, 221, 44 };
            for (int i = 0; i < brojevi.Length; i++) { 
                Console.WriteLine(brojevi[i]);
            }
            Console.WriteLine("------------------");
            Array.Sort(brojevi);
            for (int k = 0; k < brojevi.Length; k++) {
                Console.WriteLine(brojevi[k]);
            }
            Console.WriteLine("-------------------");
            Array.Reverse(brojevi);
            Console.WriteLine(brojevi[4]);
            Console.ReadLine();
        }
    }
}
