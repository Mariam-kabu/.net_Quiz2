using System;
using System.Collections;

namespace Collections
{
    public class MultiDimArray
    {
        public static void DemonstrateMultiDimArray()
        {

            Console.WriteLine("+----------------------------------------------------------------------------------------------+");

            Console.WriteLine();
            Console.WriteLine("Multi Dimensional Array");
            Console.WriteLine();

            

            // Create a 2D array (3x3 matrix) of integers
            int[,] myMatrix = new int[,]
            {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
            };

            // Add elements to collection (matrix)
            int newRow = 10;
            for (int i = 0; i < myMatrix.GetLength(1); i++)
            {
                myMatrix[1, i] = newRow++; // Adding elements to the second row
            }

            // Display the matrix after adding elements
            Console.WriteLine("Matrix after adding elements to the second row:");
            DisplayMatrix(myMatrix);

            // Search element in collection (matrix)
            int searchElement = 6;
            int[] coordinates = SearchElementInMatrix(myMatrix, searchElement);
            if (coordinates != null)
            {
                Console.WriteLine($"Element {searchElement} found at position: [{coordinates[0]}, {coordinates[1]}]");
            }
            else
            {
                Console.WriteLine($"Element {searchElement} not found in the matrix.");
            }

            // Delete element from collection (matrix)
            int elementToDelete = 8;
            myMatrix = DeleteElementFromMatrix(myMatrix, elementToDelete);

            // Display the matrix after deleting the specified element
            Console.WriteLine($"Matrix after deleting element {elementToDelete}:");
            DisplayMatrix(myMatrix);

            // Sort collection (matrix)
            // Note: Sorting a 2D array requires converting it to a 1D array first
            int[] flattenedArray = myMatrix.Cast<int>().ToArray();
            Array.Sort(flattenedArray);
            //Array.Copy(flattenedArray, myMatrix, flattenedArray.Length);

            // Display the matrix after sorting
            Console.WriteLine("Matrix after sorting:");
            DisplayMatrix(myMatrix);
        }

        // Helper method to display the matrix
        static void DisplayMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Helper method to search for an element in the matrix and return its coordinates
        static int[] SearchElementInMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == target)
                    {
                        return new int[] { i, j }; // Return row and column indices
                    }
                }
            }

            return null; // Element not found
        }

        // Helper method to delete an element from the matrix
        static int[,] DeleteElementFromMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == target)
                    {
                        matrix[i, j] = 0; // can set it to any default value
                        return matrix;
                    }
                }
            }

            return matrix; // Element not found
        }
    }
}