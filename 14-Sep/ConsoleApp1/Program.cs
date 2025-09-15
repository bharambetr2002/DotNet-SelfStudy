using System;

namespace ConsoleApp1
{
    // Class to demonstrate static and instance members
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of Main1 class to access instance variables
            Main1 main1 = new Main1();

            // Accessing instance variable 'i2' using the object
            main1.i2 = 5;
            Console.WriteLine("Instance variable i2: " + main1.i2);

            // Accessing static variable 'i' using the class name
            Main1.i = 10;
            Console.WriteLine("Static variable i: " + Main1.i);

            // Calling the static method using the class name
            Main1.DisplayStatic();

            // Calling the instance method using the object
            main1.DisplayInstance();
        }
    }

    class Main1
    {
        // Static variable: shared by all instances of the class
        public static int i;

        // Instance variables: unique to each object
        public int i2;
        public int i3;

        // Static method: can be called without creating an object
        public static void DisplayStatic()
        {
            Console.WriteLine("This is a static method.");
            Console.WriteLine("Value of static variable i = " + i);
        }

        // Instance method: requires an object to be called
        public void DisplayInstance()
        {
            Console.WriteLine("This is an instance method.");
            Console.WriteLine("Value of instance variable i2 = " + i2);
            Console.WriteLine("Value of instance variable i3 = " + i3);
        }
    }
}
