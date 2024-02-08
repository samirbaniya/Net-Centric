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

                s = s * 10 + r; //(reverse and palindrome)
                b = b / 10;
            }
            if (s == a)
            {
                Console.WriteLine("Palindrome number");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadLine();

        }
    }
}
