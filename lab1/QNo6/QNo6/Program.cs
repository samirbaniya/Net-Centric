using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNo6
{
    internal class Program
    {

        static float funcOvrld(int a, int b)
        {
            return (a + b);
        }
        static float funcOvrld(float a, float b)
        {
            return (a + b);
        }
        static float funcOvrld(int a, float b)
        {
            return (a + b);
        }
        static float funcOvrld(float a, int b)
        {
            return (a + b);
        }
        static float funcOvrld(int a, int b, int c)
        {
            return (a + b + c);
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"{funcOvrld(5,6)}");
            Console.WriteLine($"{funcOvrld(5.0f, 6.0f)}");
            Console.WriteLine($"{funcOvrld(5.0f, 6)}");
            Console.WriteLine($"{funcOvrld(5, 6.0f)}");
            Console.WriteLine($"{funcOvrld(5, 6 ,4)}");
            Console.ReadLine();
        }
    }
}
