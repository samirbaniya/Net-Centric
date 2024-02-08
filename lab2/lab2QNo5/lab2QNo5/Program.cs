using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2QNo5
{
    internal class Program
    {

        class Person
        {
            // Private fields
            private string name;
            private int age;

            // Properties
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }
        }


        static void Main()
        {
            // Creating an instance of the Person class
            Person person = new Person();

            // Using properties to set values
            person.Name = "John";
            person.Age = 25;

            // Accessing properties to retrieve values
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");

            Console.ReadLine();
        }
    }
}
