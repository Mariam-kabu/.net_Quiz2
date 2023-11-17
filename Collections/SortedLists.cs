using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class SortedLists
    {
        public static void DemonstrateSortedLists()
        {
            Console.WriteLine();
            Console.WriteLine("+----------------------------------------------------------------------------------------------+");
            Console.WriteLine();

            Console.WriteLine("Sorted List");

            Console.WriteLine();

            Console.WriteLine("Add: Adds a key / value pair to the sorted list.");
            Console.WriteLine("Access: Accesses values using keys.");
            Console.WriteLine("ContainsKey: Checks if a key exists in the sorted list.");
            Console.WriteLine("ContainsValue: Checks if a value exists in the sorted list.");
            Console.WriteLine("IndexOfKey: Gets the index of a key.");
            Console.WriteLine("IndexOfValue: Gets the index of a value.");
            Console.WriteLine("Keys: Gets a collection of keys.");
            Console.WriteLine("Values: Gets a collection of values.");
            Console.WriteLine("Remove: Removes a key / value pair by key.");
            Console.WriteLine("RemoveAt: Removes a key / value pair by index.");
            Console.WriteLine("Count: Gets the number of key / value pairs in the sorted list.");


            SortedList<int, string> Slist = new SortedList<int, string>();

            Console.WriteLine();

            Slist.Add(1, "String 1");
            Slist.Add(2, "String 2");
            Slist.Add(3, "String 3");
            Slist.Add(9, "String 9");
            Slist.Add(4, "String 4");
            Slist.Add(5, "String 5");
            Slist.Add(6, "String 6");

            foreach (KeyValuePair<int, string> kvp in Slist)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.WriteLine();

            Console.WriteLine($"Does the Sorted List contain key 3? {Slist.ContainsKey(3)}");
            Console.WriteLine($"Does the Sorted List contain value String 3? {Slist.ContainsValue("String 3")}");

            Console.WriteLine();

            Console.WriteLine($"Value of key 3: {Slist[3]}");

            Console.WriteLine();

            Console.WriteLine($"Index of key 3: {Slist.IndexOfKey(3)}");
            Console.WriteLine($"Index of value String 3: {Slist.IndexOfValue("String 3")}");

            Console.WriteLine();

            Console.WriteLine($"Key at index 3: {Slist.Keys[3]}");
            Console.WriteLine($"Value at index 3: {Slist.Values[3]}");

            //remove item from sorted list
            Slist.Remove(3);

            Slist.RemoveAt(0);

            foreach (KeyValuePair<int, string> kvp in Slist)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}
