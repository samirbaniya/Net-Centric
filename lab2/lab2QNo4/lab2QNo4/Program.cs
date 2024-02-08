using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2QNo4
{
    internal class Program
    {
        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a generic shape");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a circle");
            }
        }

        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a rectangle");
            }
        }


        static void Main()
        {
            Shape shape = new Shape();
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();

            // Using overridden methods
            shape.Draw();       // Calls the base class method
            circle.Draw();      // Calls the derived class method
            rectangle.Draw();   // Calls the derived class method

            Console.ReadLine();

        }
    }
}
