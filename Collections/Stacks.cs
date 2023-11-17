using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Collections
{
    internal class Stacks
    {
        public static void DemonstrateStack()
        {
            Console.WriteLine();
            Console.WriteLine("+----------------------------------------------------------------------------------------------+");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Stack");
            Console.WriteLine();

            Console.WriteLine("Push: Adds an element to the stack.");
            Console.WriteLine("Pop: Removes and returns the top element from the stack.");
            Console.WriteLine("Peek: Returns the top element without removing it.");
            Console.WriteLine("Count: Gets the number of elements contained in the stack.");
            Console.WriteLine("Clear: Removes all elements from the stack.");
            Console.WriteLine("ToArray: Copies the stack elements to a new array.");
            Console.WriteLine("Iteration: Iterates through the stack using a foreach loop.");

            Console.WriteLine();

            // Create a new stack of integers
            Stack<int> numberStack = new Stack<int>();

            // Push elements onto the stack
            numberStack.Push(10);
            numberStack.Push(20);
            numberStack.Push(30);

            // Peek at the top element without removing it
            Console.WriteLine("Peek: " + numberStack.Peek());

            // Pop elements off the stack
            Console.WriteLine("Pop: " + numberStack.Pop());
            Console.WriteLine("Pop: " + numberStack.Pop());

            // Check if the stack is empty
            Console.WriteLine("Is Stack Empty: " + (numberStack.Count == 0));

            // Push more elements onto the stack
            numberStack.Push(40);
            numberStack.Push(50);

            // Iterate through the stack
            Console.WriteLine("Stack elements:");
            foreach (var item in numberStack)
            {
                Console.WriteLine(item);
            }

            // Convert the stack to an array
            int[] stackArray = numberStack.ToArray();

            // Clear the stack
            numberStack.Clear();

            Console.WriteLine("Is Stack Empty after Clear: " + (numberStack.Count == 0));

        }
    }
}
