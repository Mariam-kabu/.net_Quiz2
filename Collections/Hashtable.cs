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

            // Checking if a key exists in the Hashtable
            string searchKey = "Key3";
            Console.WriteLine($"Does the Hashtable contain key '{searchKey}'? {hashtable.ContainsKey(searchKey)}");

            // Removing an entry from the Hashtable
            hashtable.Remove("Key2");

            // Displaying the updated Hashtable
            Console.WriteLine("Updated Hashtable Entries:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
    }
}
