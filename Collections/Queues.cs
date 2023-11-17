using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Queues
    { 
        public static void DemonstrateQueues()
        {
            Queue<string> Squeue = new Queue<string>();

            Console.WriteLine("+----------------------------------------------------------------------------------------------+");

            Console.WriteLine();
            Console.WriteLine("Queue");
            Console.WriteLine();


            Console.WriteLine("First in first out type of collection");
            Console.WriteLine();
            Console.WriteLine("Enqueue: Adds an element to the end of the queue.");
            Console.WriteLine("Dequeue: Removes and returns the first element from the queue.");
            Console.WriteLine("Peek: Returns the first element without removing it.");
            Console.WriteLine("Count: Gets the number of elements contained in the queue.");
            Console.WriteLine("Clear: Removes all elements from the queue.");
            Console.WriteLine("Contains: Checks if an element exists in the queue.");
            Console.WriteLine("Max: Returns the maximum value in the queue.");
            Console.WriteLine("OrderBy: Sorts the queue.");

            Console.WriteLine();
            
            Squeue.Enqueue("String 1");
            Squeue.Enqueue("String 2");
            Squeue.Enqueue("String 3");
            Squeue.Enqueue("String 9");
            Squeue.Enqueue("String 4");
            Squeue.Enqueue("String 5");
            Squeue.Enqueue("String 6");


            foreach (string q in Squeue)
            {

                Console.WriteLine(q);
            }

            Console.WriteLine();

            Console.WriteLine($"First(Oldest) element in Queue: {Squeue.Peek()}");
            Squeue.Dequeue();
            Console.WriteLine($"First(Oldest) element in Queue: {Squeue.Peek()}");

            Console.WriteLine();

            string searchitem = "String 6";

            Console.WriteLine($"Does the Queue contain {searchitem}? {Squeue.Contains(searchitem)}");

            Console.WriteLine(Squeue.Max());

            //Sort queue
            var sortedSqueue = Squeue.OrderBy(i => i);
            Console.WriteLine();
            Console.WriteLine("Sorted Queue");
            foreach (var item in sortedSqueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Clear queue
            Squeue.Clear();
            
        }
    }
}
