using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomeranjeNiza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = {1, 2, 3, 4,5 };
            int[] brojevi2 = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine(brojevi[i]);
            }
            int prviElement = brojevi[0];

            for (int i = 0; i < brojevi.Length - 1; i++)
            {
                brojevi[i] = brojevi[i + 1];
            }
            brojevi[brojevi.Length - 1] = prviElement;
            Console.WriteLine("----------");
            for (int i = 0; i < brojevi.Length; i++) { 
                Console.WriteLine(brojevi[i]);
            }
            Console.WriteLine("-----------");
            Console.WriteLine(brojevi2[4]);
            for (int i = 0; i < brojevi2.Length - 1; i++)
            {
                Console.WriteLine(brojevi2[i]);
            }
            Console.ReadLine();
        }
    }
}
