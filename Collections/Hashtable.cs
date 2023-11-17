using System;
using System.Collections;

namespace Collections
{
    public class Hashtables
    {
        public static void DemonstrateHashtable()
        {
            Console.WriteLine();
            Console.WriteLine("Hashtable");

            // Creating a Hashtable
            Hashtable hashtable = new Hashtable();

            // Adding key-value pairs to the Hashtable
            hashtable.Add("Key1", "Value1");
            hashtable.Add("Key2", "Value2");
            hashtable.Add("Key3", "Value3");
            hashtable.Add("Key4", "Value4");
            hashtable.Add("Key5", "Value5");

            // Displaying the Hashtable
            Console.WriteLine("Hashtable Entries:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.WriteLine();

            // Adding, Inserting, Searching, and Deleting Large Items
            hashtable.Add("Key6", "Large Item 1"); // Add
            hashtable["Key7"] = "Large Item 2"; // Insert
            bool containsKey = hashtable.ContainsKey("Key3"); // Search
            hashtable.Remove("Key4"); // Delete

            // Displaying the updated Hashtable
            Console.WriteLine("Updated Hashtable Entries:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.WriteLine();

            // Sorting the Hashtable by Key
            var sortedHashtable = new SortedList(hashtable);
            
            // Displaying the Sorted Hashtable
            Console.WriteLine("Sorted Hashtable Entries:");
            foreach (DictionaryEntry entry in sortedHashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.WriteLine();

            // One-dimensional array
            int[] oneDimensionalArray = { 3, 1, 4, 1, 5, 9 };

            // Displaying the One-dimensional Array
            Console.WriteLine("One-dimensional Array:");
            foreach (int num in oneDimensionalArray)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            // Multi-dimensional array
            int[,] multiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Displaying the Multi-dimensional Array
            Console.WriteLine("Multi-dimensional Array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{multiDimensionalArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
