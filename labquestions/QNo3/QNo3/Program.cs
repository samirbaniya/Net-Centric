using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact, i, n;
            fact = 1;

            Console.WriteLine("Enter number whose factorial is to be calculated: ");
            n = int.Parse(Console.ReadLine());

            for (i = 2; i <= n; i++) 
            {
                fact = fact * i;
            }

            Console.WriteLine($"The factorial of {n} is {fact}.");
            Console.ReadLine();

        }
    }
}
