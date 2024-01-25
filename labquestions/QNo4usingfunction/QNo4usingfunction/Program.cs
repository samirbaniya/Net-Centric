using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;

            Console.WriteLine("Enter number whose sum of factorial of factor is to be calculated: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + factorial(i);
                }
            }

            Console.WriteLine($"The sum of factorial of factors is {n} is {sum}.");
            Console.ReadLine();

        }

        static int factorial(int n) 
        {
            int i,fact=1;

            for(i = 2; i <= n;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
