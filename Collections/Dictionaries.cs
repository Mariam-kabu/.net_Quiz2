using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Collections
{
    internal class Dictionaries
    {
        public static void DemonstrateDictionary()
        {
            Console.WriteLine();
            Console.WriteLine("+----------------------------------------------------------------------------------------------+");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Dictionary");
            Console.WriteLine();

            Console.WriteLine("Add: Adds a key / value pair to the dictionary.");
            Console.WriteLine("Access: Accesses values using keys.");
            Console.WriteLine("ContainsKey: Checks if a key exists in the dictionary.");
            Console.WriteLine("Iteration: Iterates through key / value pairs using a foreach loop.");
            Console.WriteLine("Update: Updates the value for a key.");
            Console.WriteLine("Remove: Removes a key / value pair by key.");
            Console.WriteLine("Clear: Removes all key / value pairs from the dictionary.");
            Console.WriteLine("Count: Gets the number of key / value pairs in the dictionary.");

            Console.WriteLine();

            // Create a new dictionary with keys of type string and values of type int
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>();

            // Add key/value pairs to the dictionary
            ageDictionary.Add("Alice", 25);
            ageDictionary.Add("Bob", 30);
            ageDictionary.Add("Charlie", 22);

            // Access values using keys
            Console.WriteLine("Age of Alice: " + ageDictionary["Alice"]);

            // Check if a key exists
            if (ageDictionary.ContainsKey("Bob"))
            {
                Console.WriteLine("Bob's age exists in the dictionary.");
            }

            // Iterate through key/value pairs
            Console.WriteLine("Key/Value pairs:");
            foreach (var pair in ageDictionary)
            {
                Console.WriteLine($"Name: {pair.Key}, Age: {pair.Value}");
            }

            // Update the value for a key
            ageDictionary["Alice"] = 26;

            // Remove a key/value pair
            ageDictionary.Remove("Charlie");

            // Check if a key exists (after removal)
            if (!ageDictionary.ContainsKey("Charlie"))
            {
                Console.WriteLine("Charlie's age does not exist in the dictionary anymore.");
            }

            // Clear all key/value pairs
            ageDictionary.Clear();

            Console.WriteLine("Is Dictionary Empty after Clear: " + (ageDictionary.Count == 0));
        }
    }
}
