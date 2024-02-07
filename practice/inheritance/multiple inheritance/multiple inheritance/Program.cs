using System;

// Interface for flying behavior
interface IFlyable
{
    void Fly();
}

// Interface for swimming behavior
interface ISwimmable
{
    void Swim();
}

// Concrete class implementing both IFlyable and ISwimmable
class FlyingFish : IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("FlyingFish is flying.");
    }

    public void Swim()
    {
        Console.WriteLine("FlyingFish is swimming.");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the class
        FlyingFish myFlyingFish = new FlyingFish();

        // Accessing methods from both interfaces
        myFlyingFish.Fly();
        myFlyingFish.Swim();

        Console.ReadLine();
    }
}
