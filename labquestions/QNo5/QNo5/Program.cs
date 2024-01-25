using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter grades for five subjects:");

            Console.Write("Subject 1: ");
            int sub1=int.Parse(Console.ReadLine());

            Console.Write("Subject 2: ");
            int sub2=int.Parse(Console.ReadLine());

            Console.Write("Subject 3: ");
            int sub3=int.Parse(Console.ReadLine());

            Console.Write("Subject 4: ");
            int sub4=int.Parse(Console.ReadLine());

            Console.Write("Subject 5: ");
            int sub5 = int.Parse(Console.ReadLine());

            double avgGrade = (sub1 + sub2 + sub3 + sub4 + sub5) / 5.0;



            if(sub1<40|| sub2 < 40 || sub3 < 40 || sub4 < 40 || sub5 < 40 )
            {
                Console.WriteLine("The student is fail");
            }

            else 
            {
                if (avgGrade >= 90)
                    Console.WriteLine("Final Grade: A");
                else if (avgGrade >= 80)
                    Console.WriteLine("Final Grade: B");
                else if (avgGrade >= 70)
                    Console.WriteLine("Final Grade: C");
                else if (avgGrade >= 60)
                    Console.WriteLine("Final Grade: D");
                else
                    Console.WriteLine("Final Grade: F");
                
            }
            Console.ReadLine();

        }
    }
}
