using System;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Lambda Expression for Action ===");
            Action<string> greet = message => Console.WriteLine("Hello, " + message);
            greet("Tanmay");

            Console.WriteLine("\n=== Lambda Expression for Func ===");
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine("Addition: " + add(5, 3));

            Func<int, int, int> multiply = (a, b) => a * b;
            Console.WriteLine("Multiplication: " + multiply(5, 3));

            Console.WriteLine("\n=== Lambda Expression for Predicate ===");
            Predicate<int> isEven = n => n % 2 == 0;
            Console.WriteLine("Is 4 even? " + isEven(4));
            Console.WriteLine("Is 7 even? " + isEven(7));

            Console.WriteLine("\n=== Lambda Expression with No Parameters ===");
            Action sayHi = () => Console.WriteLine("Hi, no parameters here!");
            sayHi();

            Console.WriteLine("\n=== Lambda Expression in a List Operation ===");
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Even numbers from array:");
            foreach (var num in numbers)
            {
                if (isEven(num)) // Using predicate
                {
                    Console.WriteLine(num);
                }
            }

            Console.WriteLine("\n=== Passing Lambda as Parameter ===");
            ExecuteOperation(10, 20, (x, y) => x - y); // Subtraction
            ExecuteOperation(10, 20, (x, y) => x + y); // Addition
            ExecuteOperation(10, 20, (x, y) => x * y); // Multiplication
        }

        // Method that accepts a lambda expression as a parameter
        static void ExecuteOperation(int x, int y, Func<int, int, int> operation)
        {
            Console.WriteLine("Result: " + operation(x, y));
        }
    }
}