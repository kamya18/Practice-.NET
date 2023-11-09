using System;

namespace Enums1
{

   class Program
   {
      //days
      // enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

      // static void Main(string[] args) {
      //    int WeekdayStart = (int)Days.Mon;
      //    int WeekdayEnd = (int)Days.Fri;
      //    Console.WriteLine("Monday: {0}", WeekdayStart);
      //    Console.WriteLine("Friday: {0}", WeekdayEnd);

      //levels
      enum Level
      {
         Low,
         Medium,
         High
      }
      static void Main(string[] args)
      {
         Level myVar = Level.Medium;
         Console.WriteLine(myVar);
         Console.ReadKey();
      }
   }
}