using System;

namespace Garbagecollector
{
    class Program
    {
        static void Main()
        {
            for(int i=0;i<=10000;i++)
            {
                MyClass myObject = new MyClass(i);

                Console.WriteLine($"Created object with ID: {myObject.ID}");
            }
            // GC.Collect();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
    class MyClass
    {
        public int ID{get;}
        public MyClass(int id)
        {
            ID = id;
        }
        MyClass()
        {
            Console.WriteLine($"Finishing object with ID:{ID}");
        }
    }
}