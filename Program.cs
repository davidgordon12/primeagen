void LinkedListTest()
{
    LinkedList.List<int> mylist = new();
    mylist.Pop(); // Should do nothing.
    mylist.Unshift(); // Should do nothing.

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
    mylist.Shift(1);
    mylist.Print();

    Console.WriteLine("\nUnshifted: " + mylist.Unshift()); // 1

    // Should print 3->5->2->9->6
    mylist.Print();
}

LinkedListTest();