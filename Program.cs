LinkedList.List<int> mylist = new();

mylist.Push(3);
mylist.Push(5);
mylist.Push(2);
mylist.Push(9);
mylist.Push(6);
mylist.Push(7);
mylist.Shift(1);
mylist.Print();
Console.WriteLine("\n" + mylist.Pop());
mylist.Print();
Console.WriteLine("\n" + mylist.Unshift());
mylist.Print();
