using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNo7b
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"* ");
                    }
                    Console.WriteLine(); 
                }

                for (int i = 4; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"* ");
                    }
                    Console.WriteLine();
                }

            for (int i = 2; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }

            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
