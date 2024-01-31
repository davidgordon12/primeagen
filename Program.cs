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
}

LinkedListTest();
Console.WriteLine("\n\n===============\n");
QueueTest();