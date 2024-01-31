static void LinkedListTest()
{
    Dsa.List<int> mylist = new();
    mylist.Pop(); // Should do nothing.
    mylist.Shift(); // Should do nothing.

    // Should result in 3->5->2->9->6->7
    mylist.Push(3);
    mylist.Push(5);
    mylist.Push(2);
    mylist.Push(9);
    mylist.Push(6);
    mylist.Push(7);
    mylist.Print();
    Console.WriteLine("\nPopped: " + mylist.Pop()); // 7

    // Should result in 1->3->5->2->9->6
    mylist.Unshift(1);
    mylist.Print();

    Console.WriteLine("\nUnshifted: " + mylist.Shift()); // 1

    // Should print 3->5->2->9->6
    mylist.Print();
    Console.WriteLine("\n\n===============\n");
}

static void QueueTest()
{
    Dsa.Queue<int> queue = new Dsa.Queue<int>();
    queue.Enqueue(1);
    queue.Enqueue(2);
    queue.Enqueue(3);
    queue.Enqueue(4);

    queue.Dequeue();

    // Should print 2->3->4
    queue.Print(); 
    Console.WriteLine("\n\n===============\n");
}

static void BinarySearchTest()
{
    int[] arr = { 0, 1, 3, 9, 13, 21, 30 };
    int index = Algo.Algorithms.BinarySearch(arr, 13); // Expected return value = 4
    Console.WriteLine("Expected 4, Got " + index);
    Console.WriteLine("\n\n===============\n");
}

LinkedListTest();
QueueTest();
BinarySearchTest();