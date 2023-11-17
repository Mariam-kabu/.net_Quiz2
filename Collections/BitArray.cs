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
        }
    }
}
