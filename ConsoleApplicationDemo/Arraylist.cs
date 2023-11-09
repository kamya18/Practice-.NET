using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Hello, ");
            arrayList.Add(3.14);
            arrayList.Add(true);

            arrayList.Insert(1,"World!");

            Console.WriteLine(arrayList[0]);
            Console.WriteLine(arrayList[1]);

            arrayList[0]=42;

            arrayList.Remove(3.14);

            bool containsHello = arrayList.Contains("Hello, ");
            Console.WriteLine($"Contains 'Hello, ': {containsHello}"); 

            int index = arrayList.IndexOf("World!");
            Console.WriteLine($"Index of 'World!': {index}");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}