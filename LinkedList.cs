namespace LinkedList {
    public class Node<T>
    {
        public T value;
        public Node<T>? next;

        public Node(T value) 
        {
            this.value = value;
        }
    }

    public class List<T>
    {
        public Node<T>? head;

        public void Shift(T value)
        {
            if(head == null)
            {
                head = new Node<T>(value);
                return;
            }

            Node<T> newNode = new Node<T>(value);
            newNode.next = head;

            head = newNode;
        }

        public T? Unshift()
        {
            if(head == null)
            {
                return default;
            }

            T val = head.value;
            head = head.next;
            return val;
        }

        public void Push(T value)
        {
            if(head == null)
            {
                head = new Node<T>(value);
                return;
            }
            
            Node<T> temp = head;
            while (temp.next != null) 
            {
                temp = temp.next;
            }

            Node<T> newNode = new Node<T>(value);
            temp.next = newNode;
        }

        public T? Pop()
        {
           if(head == null)
            {
                return default;
            }
            
            Node<T> temp = head;
            while (temp!.next!.next != null) 
            {
                temp = temp.next;
            }

            T val = temp.next.value;
            temp.next = null;
            return val;
        }

        public void Print()
        {
            Node<T> temp = head!;
            while (temp != null) 
            {
                Console.Write(temp.value + "->");
                temp = temp.next!;
            }
        }
    }
}