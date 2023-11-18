using System;
using System.Collections;

namespace Collections
{
    public class OneDimArray
    {
        public static void DemonstrateOneDimArray()
        {
            // Add elements to collection (array)
            int[] myArray = new int[5];
            myArray[0] = 10;
            myArray[1] = 20;
            myArray[2] = 30;

            // Display the array after adding elements
            Console.WriteLine("Array after adding elements:");
            DisplayArray(myArray);

            // Search element in collection (array)
            int searchElement = 20;
            int index = Array.IndexOf(myArray, searchElement);
            if (index != -1)
            {
                Console.WriteLine($"Element {searchElement} found at index: {index}");
            }
            else
            {
                Console.WriteLine($"Element {searchElement} not found in the array.");
            }

            // Delete element from collection (array)
            int elementToDelete = 20;
            myArray = DeleteElementFromArray(myArray, elementToDelete);

            // Display the array after deleting the specified element
            Console.WriteLine($"Array after deleting element {elementToDelete}:");
            DisplayArray(myArray);

            // Sort collection (array)
            Array.Sort(myArray);

            // Display the array after sorting
            Console.WriteLine("Array after sorting:");
            DisplayArray(myArray);
        }

        // Helper method to display the array
        static void DisplayArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // Helper method to delete an element from the array
        static int[] DeleteElementFromArray(int[] array, int target)
        {
            int indexToDelete = Array.IndexOf(array, target);
            if (indexToDelete != -1)
            {
                array = array.Where((val, idx) => idx != indexToDelete).ToArray();
            }

            return array;
        }
    }
}