using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any three numbers: \n");
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int c = int.Parse(Console.ReadLine());


            if (a == b && b == c)
            {
                Console.WriteLine("All numbers are equal");
            }

            else if (a > b && a > c)
            {
                Console.WriteLine($"{a} is greatest");
            }

            else if (b > c)
            {
                Console.WriteLine($"{b} is greatest");
            }

            else
            {
                Console.WriteLine($"{c} is greatest");
            }

            Console.ReadLine();
        }
    }
}