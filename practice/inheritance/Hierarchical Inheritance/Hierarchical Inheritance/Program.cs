using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Derived class 1 inheriting from Animal
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

// Derived class 2 inheriting from Animal
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing.");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of the derived classes
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        // Accessing methods from the base class and the respective derived classes
        myDog.Eat();   // Method from Animal (base class) and inherited by Dog
        myDog.Bark();  // Method from Dog

        myCat.Eat();   // Method from Animal (base class) and inherited by Cat
        myCat.Meow();  // Method from Cat
        Console.ReadLine();
    }
}
