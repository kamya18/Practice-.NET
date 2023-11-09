using System;
using System.Collections.Generic;

namespace Queue
{
    class Program{
        static void Main(){
            Queue<string> queue= new Queue<string>();
            
            queue.Enqueue("Alice");
            queue.Enqueue("Bob");
            queue.Enqueue("Charlie");

            while(queue.Count>0)
            {
                string Person = queue.Dequeue();
                Console.WriteLine($"Dequeued:{Person}");
            }
        }
    }
}