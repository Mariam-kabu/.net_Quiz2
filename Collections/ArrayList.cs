using System;
using System.Collections;

namespace Collections
{
    public class ArrayLists
    {
        public static void DemonstrateArrayList()
        {
            Console.WriteLine("+----------------------------------------------------------------------------------------------+");

            Console.WriteLine();
            Console.WriteLine("ArrayList");
            Console.WriteLine();


            // Add elements to collection (ArrayList)
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(10);
            myArrayList.Add(20);
            myArrayList.Add(30);
            myArrayList.Add(40);

            // Display the ArrayList after adding elements
            Console.WriteLine("ArrayList after adding elements:");
            DisplayArrayList(myArrayList);

            // Search element in collection (ArrayList)
            int searchElement = 20;
            int index = myArrayList.IndexOf(searchElement);
            if (index != -1)
            {
                Console.WriteLine($"Element {searchElement} found at index: {index}");
            }
            else
            {
                Console.WriteLine($"Element {searchElement} not found in the ArrayList.");
            }

            // Delete element from collection (ArrayList)
            int elementToDelete = 20;
            myArrayList.Remove(elementToDelete);

            // Display the ArrayList after deleting the specified element
            Console.WriteLine($"ArrayList after deleting element {elementToDelete}:");
            DisplayArrayList(myArrayList);

            // Sort collection (ArrayList)
            myArrayList.Sort();

            // Display the ArrayList after sorting
            Console.WriteLine("ArrayList after sorting:");
            DisplayArrayList(myArrayList);
        }

        // Helper method to display the ArrayList
        static void DisplayArrayList(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}