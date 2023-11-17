using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // Define a non-generic queue class with overloaded comparers
    public class PersonQueue : IEnumerable<Person>
    {
        private readonly Queue<Person> queue;

        // Default comparer (compares by age)
        private class AgeComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            }
        }

        // Comparer for sorting by name
        private class NameComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return String.Compare(x.Name, y.Name, StringComparison.Ordinal);
            }
        }

        // Constructor
        public PersonQueue()
        {
            queue = new Queue<Person>();
        }

        // Enqueue a person
        public void Enqueue(Person person)
        {
            queue.Enqueue(person);
        }

        // Dequeue a person
        public Person Dequeue()
        {
            return queue.Dequeue();
        }

        // Get the number of persons in the queue
        public int Count
        {
            get { return queue.Count; }
        }

        // Clear the queue
        public void Clear()
        {
            queue.Clear();
        }

        // GetEnumerator for IEnumerable interface
        public IEnumerator<Person> GetEnumerator()
        {
            return queue.GetEnumerator();
        }

        // GetEnumerator for IEnumerable interface (non-generic)
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Sort the queue by age
        public void SortByAge()
        {
            var comparer = new AgeComparer();
            var sortedList = queue.OrderBy(p => p, comparer).ToList();
            queue.Clear();
            foreach (var person in sortedList)
            {
                queue.Enqueue(person);
            }
        }

        // Sort the queue by name
        public void SortByName()
        {
            var comparer = new NameComparer();
            var sortedList = queue.OrderBy(p => p, comparer).ToList();
            queue.Clear();
            foreach (var person in sortedList)
            {
                queue.Enqueue(person);
            }
        }

        public static void DemonstrateNonGenericQueue()
        {
            Console.WriteLine();
            Console.WriteLine("+----------------------------------------------------------------------------------------------+");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Non-Generic Queue");
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

            // Create a new queue of persons
            PersonQueue personQueue = new PersonQueue();

            // Add persons to the queue
            personQueue.Enqueue(new Person("Alice", 25));
            personQueue.Enqueue(new Person("Bob", 30));
            personQueue.Enqueue(new Person("Charlie", 22));

            // Iterate through the queue
            Console.WriteLine("Queue elements:");
            foreach (var person in personQueue)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            // Sort the queue by age
            personQueue.SortByAge();

            // Iterate through the queue
            Console.WriteLine("Queue elements (sorted by age):");
            foreach (var person in personQueue)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            // Sort the queue by name
            personQueue.SortByName();

            // Iterate through the queue
            Console.WriteLine("Queue elements (sorted by name):");
            foreach (var person in personQueue)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            // Check if a person exists in the queue
            if (personQueue.Contains(new Person("Bob", 30)))
            {
                Console.WriteLine("Bob exists in the queue.");
            }

            // Get the maximum age in the queue
            Console.WriteLine("Maximum age in the queue: " + personQueue.Max(p => p.Age));

            // Clear the queue
            personQueue.Clear();

            Console.WriteLine("Is Queue Empty after Clear: " + (personQueue.Count == 0));
        }
    }
}
