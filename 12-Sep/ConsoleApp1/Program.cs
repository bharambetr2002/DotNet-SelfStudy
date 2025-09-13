using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Working with a class using getter and setter methods
            Class1 obj = new Class1();
            Console.WriteLine("Enter a value (less than 100):");

            if (int.TryParse(Console.ReadLine(), out int value))
            {
                obj.SetX(value);
                Console.WriteLine("Value of x: " + obj.GetX());
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }

            Console.WriteLine();

            // Demonstrating the use of properties in C#
            LearnProperty propertyExample = new LearnProperty();
            propertyExample.X = 10; // Using the property setter to assign a value
            Console.WriteLine("Value of X using property: " + propertyExample.X); // Using the property getter to retrieve the value
        }
    }

    // Class demonstrating the use of explicit getter and setter methods
    public class Class1
    {
        private int x;

        // Setter method to assign a value with validation
        public void SetX(int value)
        {
            if (value < 100)
            {
                this.x = value;
            }
            else
            {
                Console.WriteLine("Please enter a value below 100.");
            }
        }

        // Getter method to retrieve the value
        public int GetX()
        {
            return this.x;
        }
    }

    // Class demonstrating the use of properties to encapsulate fields
    public class LearnProperty
    {
        private int x;

        // Property 'X' encapsulates the field 'x'
        // The 'set' accessor is used to assign a value to 'x'
        // The 'get' accessor is used to retrieve the value of 'x'
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        /*
         * Properties in C# are a cleaner and more controlled way to expose fields.
         * They allow you to define logic during assignment and retrieval.
         * You can also later modify the property to add validation or other logic without changing how the property is accessed.
         */
    }
}
