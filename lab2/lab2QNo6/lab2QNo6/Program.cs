using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2QNo6
{
    internal class Program
    {
        class Laptop
        {
            // Constants defined in the base class
            protected const string BaseName = "Base Laptop";
            protected const double BasePrice = 1000.00;
            protected const string BaseProcessor = "Intel Core i5";
            protected const int BaseRam = 8;
            protected const int BaseHardDrive = 256;

            // Instance variables to store unique values for each laptop
            private string name;
            private double price;
            private string processor;
            private int ram;
            private int hardDrive;

            // Constructor to initialize unique values for each laptop
            public Laptop(string name, double price, string processor, int ram, int hardDrive)
            {
                this.name = name;
                this.price = price;
                this.processor = processor;
                this.ram = ram;
                this.hardDrive = hardDrive;
            }

            // Method to print details
            public virtual void PrintDetails()
            {
                Console.WriteLine($"Laptop Name: {name}");
                Console.WriteLine($"Price: ${price}");
                Console.WriteLine($"Processor: {processor}");
                Console.WriteLine($"RAM: {ram} GB");
                Console.WriteLine($"Hard Drive: {hardDrive} GB");
                Console.WriteLine();
            }
        }

        class laptop : Laptop
        {
            // Constructor to initialize unique values for each laptop and call the base class constructor
            public laptop(string name, double price, string processor, int ram, int hardDrive)
                : base(name, price, processor, ram, hardDrive)
            {
            }

            // Override the PrintDetails method to include the base class details
            public override void PrintDetails()
            {
                base.PrintDetails(); // Call the base class method
                Console.WriteLine();
            }

            static void Main()
            {
                // Create instances of the derived class (Program)
                Laptop laptop1 = new laptop("Laptop1", 1200.00, "Intel Core i7", 16, 512);
                Laptop laptop2 = new laptop("Laptop2", 1500.00, "AMD Ryzen 5", 8, 256);

                // Call the PrintDetails method for each laptop
                laptop1.PrintDetails();
                laptop2.PrintDetails();

                // Keep the console window open
                Console.ReadLine();
            }
        }

    }
}
