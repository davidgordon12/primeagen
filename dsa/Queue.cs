namespace Dsa 
{
    public class Queue<T>
    {
        List<T> list = new List<T>();
        
        public void Enqueue(T value)
        {
            list.Push(value);
        }

        public T? Dequeue()
        {
            return list.Unshift();
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