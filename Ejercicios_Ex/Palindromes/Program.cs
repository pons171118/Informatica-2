using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {




        static void Main(string[] args)
        {
            string p1;
            string p2;

            Console.WriteLine("Ingrese una palabra");
            p1 = Console.ReadLine();
            Console.WriteLine("Ingrese una segunda palabra");
            p2 = Console.ReadLine();

            char[] charArray = p2.ToCharArray();
            Array.Reverse(charArray);
            string p3 = new string(charArray);
            if (p1.Equals(p3))
            {
                Console.WriteLine("Si son palindromes");
            }
            else { Console.WriteLine("No son palindromes); }
            Console.ReadLine();

        }
    }
}



