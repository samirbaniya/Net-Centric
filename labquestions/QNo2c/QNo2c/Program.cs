using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNo2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, r, s = 0;
            Console.WriteLine("Enter a number: ");
            a = int.Parse(Console.ReadLine());
            b = a;

            while (b > 0)
            {
                r = b % 10;
                s = s+r; //(To findout the dudeney number)
                b = b / 10;

            }
            s = (int)(Math.Pow(s, 3));

            if (s == a)
            {
                Console.WriteLine("Dudeney number");
            }
            else
            {
                Console.WriteLine("Not dudeney");
            }
            Console.ReadLine();

        }
    }
}
