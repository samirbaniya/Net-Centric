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
            int fact, i,j, n,sum=0;

            Console.WriteLine("Enter number whose sum of factorial of factor is to be calculated: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if(n%i==0)
                {
                    fact = 1;
                    for (j = 1; j <= i;j++)
                    {
                        fact = fact * j;
                    }
                    sum =sum+ fact;
                    
                }
            }

            Console.WriteLine($"The sum of factorial of factors is {n} is {sum}.");
            Console.ReadLine();

        }
    }
}
