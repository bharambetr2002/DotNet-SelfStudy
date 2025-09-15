using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Creating an array
            int[] arr = new int[5];

            // 2. Taking input
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter value for arr({i}): ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nOriginal array:");
            PrintArray(arr);

            // 3. Array.Length - gets the length of the array
            Console.WriteLine($"\nLength of the array is: {arr.Length}");

            // 4. Array.Sort() - sorts the array in ascending order
            Array.Sort(arr);
            Console.WriteLine("\nSorted array:");
            PrintArray(arr);

            // 5. Array.Reverse() - reverses the array
            Array.Reverse(arr);
            Console.WriteLine("\nReversed array:");
            PrintArray(arr);

            // 6. Array.IndexOf() - finds the index of an element
            Console.Write("\nEnter a number to search: ");
            int searchValue = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(arr, searchValue);
            if (index >= 0)
                Console.WriteLine($"Element {searchValue} found at index {index}");
            else
                Console.WriteLine($"Element {searchValue} not found");

            // 7. Array.Exists() - checks if any element matches condition
            bool exists = Array.Exists(arr, element => element > 10);
            Console.WriteLine($"\nIs there any element greater than 10? {exists}");

            // 8. Array.Find() - finds first element matching condition
            int found = Array.Find(arr, element => element > 10);
            Console.WriteLine($"First element greater than 10: {found}");

            // 9. Array.FindAll() - finds all elements matching condition
            int[] allFound = Array.FindAll(arr, element => element > 10);
            Console.WriteLine("All elements greater than 10:");
            PrintArray(allFound);

            // 10. Array.Copy() - copies elements to another array
            int[] copy = new int[arr.Length];
            Array.Copy(arr, copy, arr.Length);
            Console.WriteLine("\nCopied array:");
            PrintArray(copy);

            // 11. Array.Clear() - clears elements by setting them to default
            Array.Clear(copy, 0, copy.Length);
            Console.WriteLine("\nCleared copied array:");
            PrintArray(copy);

            // 12. Array.Resize() - resizes the array (creates new one internally)
            Array.Resize(ref arr, 7);
            Console.WriteLine("\nResized array (length = 7):");
            PrintArray(arr);

            // 13. Iterating with foreach
            Console.WriteLine("\nIterating using foreach:");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // 14. Iterating with for
            Console.WriteLine("\nIterating using for loop:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // Helper method to print arrays
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}