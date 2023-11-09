// // See https://aka.ms/new-console-template for more information

//Polymorphism,Inheritance,overloading and overriding

// using System.Transactions;

// class Program{
//     void hello(){
//         Console.WriteLine("Hello India");
//     }

//     void hello(string s){
//         Console.WriteLine(s);
//     }

//     void hello(string s,int num){
//         Console.WriteLine(s + " your number is "+ num);
//     }

//     public int Add(int num1, int num2){
//         return (num1 + num2);
//     }

//     public float Add(float num1, float num2){
//         return (num1 + num2);
//     }

//     class A{
//         public void bye(){
//             Console.WriteLine("Bye A");
//         }
//     }

//     class B:A{
//         public new void bye(){
//             Console.WriteLine("Bye B");
//         }
//     }

//     class Baseclass{
//         public virtual void Sum(int n1, int n2){
//             return (n1 + n2);
//         }
//     }

//     class Childclass : Baseclass{
//         public override int Sum(int n1, int n2){
//             if(n1<=0 || n2<=0){
//                 Console.WriteLine("Values should be less than or equal to zero");
//                 Console.WriteLine("Enter first number: ");
//                 n1 = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Enter second number: ");
//                 n2 = Convert.ToInt32(Console.ReadLine());

//             }
//             return (n1+ n2);
//         }
//     }

//     public void Main(string[] args){
//         //Program p1 = new Program();
//         // p1.hello();
//         // p1.hello("Hello");
//         // p1.hello("Hello World",10);
//         // Console.WriteLine("Adding of two integer numbers is "+p1.Add(5,6));
//         // Console.WriteLine("Adding of two float numbers is "+p1.Add(7.2f,6f));
//         // A a;
//         // B b;
//         // a = new A();
//         // b =new B();
//         // a.bye();
//         // b.bye();
//         // a = new B();
//         // a.bye();
//         Baseclass baseobj;
//         baseobj = new Baseclass();
//         Console.WriteLine("Sum to two numbers is"+ baseobj.Sum(-3,4));
//         baseobj = new Childclass();
//         Console.WriteLine("Sum to two numbers is"+ baseobj.Sum(-2,2));
//         Console.ReadLine();
//     }
// }


//IEnumerable and IEnumerator

// using System;
// using System.Collections.Generic;

// public class Program
// {
//     static void Main()
//     {
//       List<int> nums= new List<int>(){1,2,3,4,5,6,7,8,9,10};

//       IEnumerator<int> enumr=nums.GetEnumerator();

//       while(enumr.MoveNext()){
//         Console.WriteLine(enumr.Current);
//       }

//         Console.WriteLine(GC.GetTotalMemory(false));
        
//     }
// }

//IComparer

// using System;
// using System.Collections.Generic;


// namespace IComparable{
//   public class Person
//   {
//     public string name{get;set;}=null!;
//     public int age{get;set;}
//     public int weight{get;set;}
//   }

//   public class AgeComparer: IComparer<Person>
//   {
//     public int Compare(Person x,Person y)
//     {
//       return x.age-y.age;
//     }
//   }

//   public class Program
//   {
//     public static void Main()
//     {
//       List<Person> people=new List<Person>{
//         new Person{name="aaa",age=28,weight=70},
//         new Person{name="aab",age=20,weight=60},
//         new Person{name="aac",age=22,weight=65},
//         new Person{name="aad",age=18,weight=55},
//         new Person{name="aae",age=33,weight=68}
//       };
//       people.Sort(new AgeComparer());

//       foreach(var i in people)
//       {
//         Console.WriteLine($"{i.name} is {i.age} years old having weight {i.weight}KG.");
//       }
//     }
//   }
// }

//IEnumerable and IEnumerator

// using System;
// using System.Collections;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = { 1, 2, 3, 4, 5 };

//         // Creating an IEnumerable from the array
//         IEnumerable<int> enumerable = numbers;

//         // Getting an IEnumerator from the IEnumerable
//         IEnumerator<int> enumerator = enumerable.GetEnumerator();

//         // Using the IEnumerator to iterate through the array
//         while (enumerator.MoveNext())
//         {
//             int number = enumerator.Current;
//             Console.WriteLine(number);
//         }

//         // Dispose of the enumerator
//         enumerator.Dispose();
//     }
// }

// using System;
// using System.Collections;
// using System.Collections.Generic;

// class CustomCollection<T> : IEnumerable<T>
// {
//     private List<T> items = new List<T>();

//     public void Add(T item)
//     {
//         items.Add(item);
//     }

//     public IEnumerator<T> GetEnumerator()
//     {
//         return new CustomEnumerator<T>(items);
//     }

//     IEnumerator IEnumerable.GetEnumerator()
//     {
//         return GetEnumerator();
//     }
// }

// class CustomEnumerator<T> : IEnumerator<T>
// {
//     private List<T> items;
//     private int position = -1;

//     public CustomEnumerator(List<T> items)
//     {
//         this.items = items;
//     }

//     public T Current => items[position];

//     object IEnumerator.Current => Current;

//     public bool MoveNext()
//     {
//         position++;
//         return position < items.Count;
//     }

//     public void Reset()
//     {
//         position = -1;
//     }

//     public void Dispose()
//     {
//         // Dispose logic if needed
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         CustomCollection<int> collection = new CustomCollection<int>();
//         collection.Add(1);
//         collection.Add(2);
//         collection.Add(3);

//         foreach (int item in collection)
//         {
//             Console.WriteLine(item);
//         }
//     }
// }
