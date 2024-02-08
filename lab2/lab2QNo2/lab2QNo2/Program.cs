using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab2QNo2
{
    internal class Program
    {
        public class Rectangle
        {
            public int length, breadth;

            public Rectangle()
            {
                length = 0;
                breadth = 0;
            }

            public Rectangle(int length, int breadth)
            {
                this.length = length;
                this.breadth = breadth;
                Console.WriteLine($"The area of the rectangle is {length * breadth}");
            }

           /* public int area(int x, int y)
            {
                int area = x * y;
                return area;
            }*/

        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Rectangle rectangle2 = new Rectangle(2, 5);

           /* 
              int area = rectangle.area(2, 5);
              Console.WriteLine($"The area is {area}");
           */

            Console.ReadLine();
        }
    }
}
