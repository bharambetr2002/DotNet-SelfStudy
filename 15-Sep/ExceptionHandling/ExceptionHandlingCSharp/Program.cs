using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

//Custom exception class
class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {

    }
}

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("---Basic Try-Catch Example---");
            BasicTryCatch();
            System.Console.WriteLine("---Multiple Try-Catch Example---");
            MultipleTryCatch();
            System.Console.WriteLine("---Finally Block Example---");
            FinallyExample();
            System.Console.WriteLine("---Throwing Custom Example---");
            CustomExceptionExample();
            System.Console.WriteLine("---Nested Try-Catch Example---");
            NestedTryCatch();
        }

        static void CustomExceptionExample()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 18)
                {
                    throw new CustomException("You must be at least 18 years old.");
                }

                Console.WriteLine("Access granted.");
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid number." + ex.Message);
            }
        }

        static void NestedTryCatch()
        {
            try
            {
                Console.WriteLine("Outer try block.");
                try
                {
                    Console.Write("Enter a number: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine(100 / num);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Inner catch: Cannot divide by zero." + ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Outer catch: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Outer finally: This always executes.");
            }
        }

        private static void FinallyExample()
        {
            try
            {
                System.Console.WriteLine("Trying to access array elements");
                int[] arr = new int[3] { 1, 2, 3 };
                System.Console.WriteLine(arr[5]);//throwing error purposely
            }
            catch (IndexOutOfRangeException ex)
            {
                System.Console.WriteLine("Error : Array Index out of range. " + ex.Message);
            }
            finally
            {
                System.Console.WriteLine("Finally Block always runs, cleaning up resources");
            }
        }

        private static void MultipleTryCatch()
        {
            try
            {
                System.Console.WriteLine("Enter a divisor : ");
                int divisor = int.Parse(Console.ReadLine());
                int result = 10 / divisor;
                System.Console.WriteLine("Result is " + result);
            }
            catch (DivideByZeroException ex)
            {
                System.Console.WriteLine("Error : Cant not divide with zero" + ex.Message);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Format Exception : Please enter a valid number : " + ex.Message);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("An unexpected error occured" + ex.Message);
            }
        }

        private static void BasicTryCatch()
        {
            try
            {
                System.Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
                System.Console.WriteLine($"You entered {num}");
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Format Exception : Please enter a valid number : " + ex.Message);
            }
        }
    }
}