using System;
using System.Collections.Generic;

namespace Stack 
{
    class Program
    {
        static void Main(){
            Stack<int> stack = new Stack<int>();
            
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Push(4);
            stack.Push(5);
            stack.Peek();
            stack.Pop();

            int item1 = stack.Peek();
            Console.WriteLine($"Peeked: {item1}");

            while(stack.Count>0)
            {
                int item = stack.Pop();
                Console.WriteLine($"Popped: {item}");
            }
        }
    }
}