namespace Dsa 
{
    public class Stack<T>
    {
        List<T> list = new List<T>();

        public void Push(T value)
        {
            list.Push(value);
        }

        public T? Pop()
        {
            return list.Pop();
        }

        public void Print()
        {
            Node<T> temp = list.head!;
            while (temp != null) 
            {
                Console.Write(temp.value + "->");
                temp = temp.next!;
            }
        }
    }
}