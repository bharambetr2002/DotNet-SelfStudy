using System;

namespace DelegateDemo
{
    // Step 1: Declare a delegate type
    public delegate void SimpleDelegate(string message);
    public delegate int MathOperation(int a, int b);
    public delegate bool CheckNumber(int number);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Simple Delegate Example ===");
            SimpleDelegate simple = DisplayMessage;
            simple("Hello from Simple Delegate!");

            Console.WriteLine("\n=== Multicast Delegate Example ===");
            SimpleDelegate multi = DisplayMessage;
            multi += DisplayAnotherMessage;
            multi("Hello from Multicast Delegate!");

            Console.WriteLine("\n=== Delegate with Parameters and Return Value ===");
            MathOperation add = Add;
            MathOperation multiply = Multiply;
            Console.WriteLine("Add: " + add(5, 10));
            Console.WriteLine("Multiply: " + multiply(5, 10));

            Console.WriteLine("\n=== Using Action Delegate ===");
            Action<string> action = msg => Console.WriteLine("Action says: " + msg);
            action("Hello Action!");

            Console.WriteLine("\n=== Using Func Delegate ===");
            Func<int, int, int> func = (x, y) => x * y;
            Console.WriteLine("Func result: " + func(4, 5));

            Console.WriteLine("\n=== Using Predicate Delegate ===");
            Predicate<int> isEven = num => num % 2 == 0;
            Console.WriteLine("Is 4 even? " + isEven(4));
            Console.WriteLine("Is 5 even? " + isEven(5));

            Console.WriteLine("\n=== Anonymous Method Example ===");
            MathOperation subtract = delegate (int a, int b)
            {
                return a - b;
            };
            Console.WriteLine("Subtract: " + subtract(10, 4));

            Console.WriteLine("\n=== Lambda Expression Example ===");
            MathOperation divide = (a, b) => b != 0 ? a / b : 0;
            Console.WriteLine("Divide: " + divide(20, 4));

            Console.WriteLine("\n=== Delegate as Parameter Example ===");
            PerformOperation(3, 7, add);
            PerformOperation(3, 7, multiply);
        }

        // Method used with SimpleDelegate
        static void DisplayMessage(string msg)
        {
            Console.WriteLine("DisplayMessage: " + msg);
        }

        // Another method used with SimpleDelegate to demonstrate multicast
        static void DisplayAnotherMessage(string msg)
        {
            Console.WriteLine("DisplayAnotherMessage: " + msg);
        }

        // Methods used with MathOperation
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method that takes a delegate as a parameter
        static void PerformOperation(int x, int y, MathOperation operation)
        {
            Console.WriteLine("PerformOperation result: " + operation(x, y));
        }
    }
}