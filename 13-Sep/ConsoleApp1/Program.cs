using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object using object initializer to set multiple properties at once
            Class1 class1 = new Class1
            {
                A = 1,              // Assigning integer property
                B = "Hello",        // Assigning string property
                C = 3.14            // Assigning double property
            };
            Console.WriteLine("class1 details:");
            Console.WriteLine($"A = {class1.A}");
            Console.WriteLine($"B = {class1.B}");
            Console.WriteLine($"C = {class1.C}");

            // Another object using the default constructor values
            Class1 class2 = new Class1();
            Console.WriteLine("\nclass2 details (default values):");
            Console.WriteLine($"A = {class2.A}");
            Console.WriteLine($"B = {class2.B}");
            Console.WriteLine($"C = {class2.C}");

            // Object initializer overriding only some values
            Class1 class3 = new Class1
            {
                B = "World"
            };
            Console.WriteLine("\nclass3 details (partial override):");
            Console.WriteLine($"A = {class3.A}");
            Console.WriteLine($"B = {class3.B}");
            Console.WriteLine($"C = {class3.C}");

            // Demonstrating that properties can be changed later
            class3.C = 2.71;
            Console.WriteLine("\nclass3 details after modifying property C:");
            Console.WriteLine($"A = {class3.A}");
            Console.WriteLine($"B = {class3.B}");
            Console.WriteLine($"C = {class3.C}");
        }
    }

    // Class demonstrating auto-implemented properties
    class Class1
    {
        // Auto-implemented properties:
        // The compiler generates a hidden backing field automatically
        public int A { get; set; }
        public string B { get; set; }
        public double C { get; set; }

        // Constructor initializes properties with default values
        public Class1()
        {
            A = 10;
            B = "Default";
            C = 0.0;
        }

        /*
         * Notes on properties:
         * - Properties are a way to expose fields in a controlled manner.
         * - Auto-implemented properties are useful when no extra logic is needed.
         * - You can later expand them by adding logic in the get or set accessors.
         * - Properties help maintain encapsulation while keeping the code clean.
         */
    }
}
