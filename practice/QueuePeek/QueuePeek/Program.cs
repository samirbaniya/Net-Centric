using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a queue
        Queue<int> myQueue = new Queue<int>();

        // Enqueuing elements
        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);

        // Peeking at the element at the beginning of the queue
        if (myQueue.Count > 0)
        {
            int peekedValue = myQueue.Peek();
            Console.WriteLine($"Peeked value: {peekedValue}");
        }
        else
        {
            Console.WriteLine("The queue is empty.");
        }

        // Displaying the queue (still contains all elements)
        Console.WriteLine("\nQueue after peeking:");
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}
