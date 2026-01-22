using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

Console.WriteLine("\n======================\nSimple Queue\n======================");

var queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Dequeue();
queue.Dequeue();
queue.Enqueue(4);
queue.Enqueue(5);
queue.Dequeue();
queue.Enqueue(6);
queue.Enqueue(7);
queue.Enqueue(8);
queue.Enqueue(9);
queue.Dequeue();
queue.Dequeue();
queue.Enqueue(10);
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Enqueue(11);
queue.Enqueue(12);
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Enqueue(13);
queue.Enqueue(14);
queue.Enqueue(15);
queue.Enqueue(16);
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Enqueue(17);
queue.Enqueue(18);
queue.Dequeue();
queue.Enqueue(19);
queue.Enqueue(20);
queue.Dequeue();
queue.Dequeue();

Console.WriteLine("Final contents:");
Console.WriteLine(String.Join(", ", queue.ToArray()));      

    }
}
