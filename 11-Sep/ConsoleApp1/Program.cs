using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var helper = new Helper();

            // Calling different overloads of Display
            helper.Display();
            Console.WriteLine("Write a word to print : ");
            string? input = Console.ReadLine();
            helper.Display(input);
            helper.Display("Tanmay");

            // Calling Add with different parameters
            helper.Add(10, 20);
            helper.Add(10, 20, 30);

            // Named Parameters - the sequence here can be anything, it is not compulsory; it should be the same way
            helper.Add(a: 30, b: 30);
            helper.Add(a: 30, c: 30);
            helper.Add(10, c: 30);


            // Local Function 
            int a = 10;
            void Display() // This local function cannot have access specifiers.
            // local functions are implicitly private
            {
                Console.WriteLine("The local function is calling a : " + a);
            }
            Display();
        }
    }

    public class Helper
    {
        // Display method without parameters
        public void Display()
        {
            Console.WriteLine("Hello from Display");
        }

        // Display method with one string parameter
        public void Display(string? message)
        {
            Console.WriteLine("Entered Word : " + message);
        }

        // Add method with optional third parameter
        public void Add(int a, int b = 0, int c = 0)
        {
            int sum = a + b + c;
            Console.WriteLine($"The addition is: {sum}");
        }
    }
}
