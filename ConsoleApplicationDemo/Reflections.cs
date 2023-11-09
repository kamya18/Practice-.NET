using System;
using System.Reflection;

namespace Reflections
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            // Create an instance of the Person class.
            Person person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30
            };

            // Get the type of the Person class using reflection.
            Type personType = typeof(Person);

            // Get all the properties of the Person class.
            PropertyInfo[] properties = personType.GetProperties();

            // Loop through the properties and display their names and values.
            foreach (var property in properties)
            {
                string propertyName = property.Name;
                object propertyValue = property.GetValue(person);

                Console.WriteLine($"{propertyName}: {propertyValue}");
            }
        }
    }
}
