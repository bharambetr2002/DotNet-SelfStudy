using System;
using System.Numerics;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using MyTotal with int
            MyTotal<int> totalInt = new MyTotal<int>();
            System.Console.WriteLine($"Sum of numbers - int is {totalInt.Add(6, 10)}");

            //float
            MyTotal<float> totalFloat = new MyTotal<float>();
            System.Console.WriteLine($"Sum of numbers - float is {totalFloat.Add(6.1f, 10.1f)}");

            //double
            MyTotal<double> totalDouble = new MyTotal<double>();
            System.Console.WriteLine($"Sum of numbers - double is {totalDouble.Add(6.120, 10.2123)}");

            //decimal
            MyTotal<decimal> totalDecimal = new MyTotal<decimal>();
            System.Console.WriteLine($"Sum of numbers - decimal is {totalDecimal.Add(6.120m, 10.2123m)}");

            //Generics using the MyStack - on string
            MyStack<string> stringStack = new MyStack<string>();
            stringStack.Push("Hello");
            stringStack.Push("Dev");
            stringStack.Push("Welcome");
            stringStack.Push("Back");
            System.Console.WriteLine("Poped from the stack" + stringStack.Pop());
            System.Console.WriteLine("Poped from the stack" + stringStack.Pop());
            System.Console.WriteLine("Poped from the stack" + stringStack.Pop());
            System.Console.WriteLine("Poped from the stack" + stringStack.Pop());

            //Generics using the MyStack - on int
            MyStack<int> intStack = new MyStack<int>();
            intStack.Push(10);
            intStack.Push(20);
            System.Console.WriteLine("Popeed from the stack" + intStack.Pop());
            System.Console.WriteLine("Popeed from the stack" + intStack.Pop());
        }
    }

    // Generic class for addition
    class MyTotal<T>
    {
        public T Add(T a, T b)
        {
            //dynamic is used when we want the compiler to understand or decide the datatype on the run time.
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }

    }

    class MyStack<T>
    {
        private List<T> elements = new List<T>();

        public void Push(T item)
        {
            elements.Add(item);
            System.Console.WriteLine($"Pushed {item} on to the stack");
        }
        public T Pop()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stack is Empty");
            }
            T item = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return item;
        }
    }
}