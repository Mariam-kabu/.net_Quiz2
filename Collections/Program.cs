using Collections;

Console.WriteLine("Hello, World!");


bool exitRequested = false;
Console.WriteLine("Welcome to the Collections demo program!");
Console.WriteLine("Press Enter to open the menu."); 

while (!exitRequested)
{
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine();
    DisplayMenu();

    string userInput = Console.ReadLine();

    switch (userInput.ToLower())
    {
        case "1":
            Console.WriteLine("Option 1 selected. Performing action...");
            Queues.DemonstrateQueues();
            break;

        case "2":
            Console.WriteLine("Option 2 selected. Performing action...");
            SortedLists.DemonstrateSortedLists();
            break;

        case "3":
            Console.WriteLine("Option 3 selected. Performing action...");
            BitArrays.DemonstrateBitArrays();
            break;
        case "4":
            Console.WriteLine("Option 4 selected. Performing action...");
            Hashtables.DemonstrateHashtable();
            break;
        case "5":
            Console.WriteLine("Option 5 selected. Performing action...");
            Dictionaries.DemonstrateDictionary();
            break;
        case "6":
            Console.WriteLine("Option 6 selected. Performing action...");
            Stacks.DemonstrateStack();
            break;
        case "7":
            Console.WriteLine("Option 7 selected. Performing action...");
            PersonQueue.DemonstrateNonGenericQueue();
            break;
        case "8":
            Console.WriteLine("Option 8 selected. Performing action...");
            OneDimArray.DemonstrateOneDimArray();
            break;
        case "9":
            Console.WriteLine("Option 9 selected. Performing action...");
            MultiDimArray.DemonstrateMultiDimArray();
            break;
        case "10":
            Console.WriteLine("Option 10 selected. Performing action...");
            ArrayLists.DemonstrateArrayList();
            break;


        case "exit":
            Console.WriteLine("Exiting the program. Goodbye!");
            exitRequested = true;
            break;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

    // Add a line break for better readability
    Console.WriteLine();
}

static void DisplayMenu()
{
    Console.WriteLine("Menu Options:");
    Console.WriteLine("1. Queue");
    Console.WriteLine("2. Sorted List");
    Console.WriteLine("3. Bit Array");
    Console.WriteLine("4. Hashtable");
    Console.WriteLine("5. Dictionary");
    Console.WriteLine("6. Stack");
    Console.WriteLine("7. Non-Generic Queue");
    Console.WriteLine("8. Array");
    Console.WriteLine("9. MultiDimensional Array");
    Console.WriteLine("10. ArrayList");
    Console.WriteLine("Type 'exit' to exit the program.");
    Console.Write("Enter your choice: ");
}
