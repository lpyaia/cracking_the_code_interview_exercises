namespace _3_3
{
    public class Stack<T>
    {
        public StackNode<T>? Top { get; set; } = default;

        public int Size { get; private set; }

        public int Count { get; private set; }

        public Stack(int size)
        {
            Size = size;
        }

        public T Pop()
        {
            if (Top == null) throw new InvalidOperationException("Stack is empty.");

            T item = Top.Data;

            Top = Top.Next;

            Count--;

            return item;
        }

        public bool Push(T data)
        {
            if (Count < Size)
            {
                StackNode<T> node = new StackNode<T>(data);

                node.Next = Top;
                Top = node;

                Count++;

                return true;
            }

            return false;
        }

        public T Peek()
        {
            if (Top == null) throw new InvalidOperationException("Stack is empty.");

            return Top.Data;
        }

        public bool IsFull() => Count == Size;

        public bool IsEmpty() => Top == null;

        public class StackNode<T>
        {
            public T Data { get; set; }

            public StackNode<T>? Next { get; set; } = default;

            public StackNode(T data)
            {
                Data = data;
            }
        }
    }
}