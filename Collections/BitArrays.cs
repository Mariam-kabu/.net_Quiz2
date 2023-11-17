using System;
using System.Collections;

namespace Collections
{
    public class BitArrays
    {
        public static void DemonstrateBitArrays()
        {
            Console.WriteLine();
            Console.WriteLine("BitArray");

            // Creating a BitArray
            BitArray bitArray = new BitArray(8);

            // Setting bits in the BitArray
            bitArray[0] = true;
            bitArray[2] = true;
            bitArray[4] = true;
            bitArray[6] = true;

            // Displaying the BitArray
            Console.WriteLine("BitArray Values:");
            for (int i = 0; i < bitArray.Count; i++)
            {
                Console.Write($"{bitArray[i]} ");
            }

            Console.WriteLine();

            // Adding, Inserting, Searching, and Deleting Large Items
            bitArray.Set(1, true); // Add
            bitArray.Set(3, true); // Insert
            bool containsValue = bitArray.Get(2); // Search
            bitArray.Set(4, false); // Delete

            // Displaying the updated BitArray
            Console.WriteLine("Updated BitArray Values:");
            for (int i = 0; i < bitArray.Count; i++)
            {
                Console.Write($"{bitArray[i]} ");
            }

            Console.WriteLine();

            // Sorting the BitArray
            bitArray = new BitArray(new bool[] { true, false, true, false, true, false, true, false });
            
            // Displaying the sorted BitArray
            Console.WriteLine("Sorted BitArray Values:");
            for (int i = 0; i < bitArray.Count; i++)
            {
                Console.Write($"{bitArray[i]} ");
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

            Console.WriteLine();

            // Sorting a one-dimensional array
            Array.Sort(oneDimensionalArray);

            // Displaying the Sorted One-dimensional Array
            Console.WriteLine("Sorted One-dimensional Array:");
            foreach (int num in oneDimensionalArray)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
        }
    }
}
