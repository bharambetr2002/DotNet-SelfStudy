using System;
using System.Collections;
using System.Data.Common;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ArrayList Operations ===");
            ArrayListOperations();

            Console.WriteLine("\n=== Hashtable Operations ===");
            HashtableOperations();

            Console.WriteLine("\n=== SortedList Operations ===");
            SortedListOperations();
        }

        private static void HashtableOperations()
        {
            Hashtable hashtable = new Hashtable();

            //add elements
            hashtable.Add(1, "One");
            hashtable.Add(2, "Two");
            hashtable.Add(3, "Three");

            System.Console.WriteLine("After adding Elements : ");
            Display(hashtable);
            System.Console.WriteLine();

            //update a value
            hashtable[2] = "Two Updated";
            System.Console.WriteLine("After updating Element 2 : ");
            Display(hashtable);
            System.Console.WriteLine();

            //remove an element
            hashtable.Remove(3);
            System.Console.WriteLine("After removing key 3: ");
            Display(hashtable);
            System.Console.WriteLine();

            //contains
            bool containsKey = hashtable.ContainsKey(1);
            bool containsValue = hashtable.ContainsValue("One");
            System.Console.WriteLine($"Does the hashtable contains key : 1 - {containsKey} & does the table contains value One - {containsValue}");

            //clear
            hashtable.Clear();
            System.Console.WriteLine("After clearing hashtable");
            Display(hashtable);
        }

        private static void SortedListOperations()
        {
            SortedList sortedList = new SortedList();

            //add elements 
            sortedList.Add("c", "Cat");
            sortedList.Add("a", "Apple");
            sortedList.Add("b", "Ball");

            System.Console.WriteLine("After adding elements (sorted by key):");
            Display(sortedList);
            System.Console.WriteLine();

            //update value
            System.Console.WriteLine("After updating key b: ");
            sortedList["b"] = "Bat";
            Display(sortedList);
            System.Console.WriteLine();

            //Remove Element 
            sortedList.Remove("a");
            System.Console.WriteLine("After removing element a : ");
            Display(sortedList);
            System.Console.WriteLine();


            //Contains
            bool containsKey = sortedList.ContainsKey("c");
            bool containsValue = sortedList.ContainsValue("Cat");
            Console.WriteLine($"\nContains key 'c'? {containsKey}");
            Console.WriteLine($"Contains value 'Cat'? {containsValue}");

            //IndexOfKey and IndexOfValue
            int keyIndex = sortedList.IndexOfKey("b");
            int valueIndex = sortedList.IndexOfValue("Bat");
            Console.WriteLine($"\nIndex of key 'b': {keyIndex}");
            Console.WriteLine($"Index of value 'Bat': {valueIndex}");

            //Clear
            sortedList.Clear();
            Console.WriteLine("\nAfter clearing SortedList:");
            Display(sortedList);

        }

        static void ArrayListOperations()
        {
            ArrayList arrayList = new ArrayList();

            // Add elements
            arrayList.Add(100);
            arrayList.Add(200);
            arrayList.Add("Hello");
            arrayList.Add(300);
            arrayList.Add("World");

            Console.WriteLine("After adding elements:");
            Display(arrayList);

            // Insert
            arrayList.Insert(2, "Inserted Element");
            Console.WriteLine("\nAfter inserting at index 2:");
            Display(arrayList);

            // Remove by value
            arrayList.Remove(200);
            Console.WriteLine("\nAfter removing 200:");
            Display(arrayList);

            // Remove at index
            arrayList.RemoveAt(3);
            Console.WriteLine("\nAfter removing at index 3:");
            Display(arrayList);

            // IndexOf
            int index = arrayList.IndexOf("World");
            Console.WriteLine($"\nIndex of 'World': {index}");

            // Contains
            bool contains = arrayList.Contains("Hello");
            Console.WriteLine($"Contains 'Hello'? {contains}");

            // Sort (only for uniform types)
            ArrayList numbers = new ArrayList() { 50, 20, 40, 10, 30 };
            numbers.Sort();
            Console.WriteLine("\nSorted ArrayList:");
            Display(numbers);

            // Reverse
            numbers.Reverse();
            Console.WriteLine("\nReversed ArrayList:");
            Display(numbers);

            // Clear
            arrayList.Clear();
            Console.WriteLine("\nAfter clearing ArrayList:");
            Display(arrayList);
        }



        // Helper method to display ArrayList
        static void Display(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Helper method to display Hashtable
        static void Display(Hashtable table)
        {
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

        // Helper method to display SortedList
        static void Display(SortedList list)
        {
            foreach (DictionaryEntry entry in list)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
    }
}