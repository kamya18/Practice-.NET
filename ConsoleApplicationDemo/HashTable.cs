using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("John",25);
            hashtable.Add("Bob",22);
            hashtable.Add("Alice",30);

            int johnage = (int)hashtable["John"];
            int aliceage = (int)hashtable["Alice"];

            Console.WriteLine($"John's age:{johnage}");
            Console.WriteLine($"Alice's age:{aliceage}");

            bool hasKey = hashtable.Contains("Eve");
            Console.WriteLine($"Does the hashtable contain a key 'Eve'? {hasKey}");

            hashtable.Remove("Bob");

            foreach(var key in hashtable.Keys)
            {
                Console.WriteLine($"Key: {key},Value:{hashtable[key]}");
            }
        }
    }
}