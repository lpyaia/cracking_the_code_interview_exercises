namespace _3_5
{
    public class Stack<T>
    {
        public StackNode<T>? Top { get; set; } = default;

        public T Pop()
        {
            if (Top == null) throw new InvalidOperationException("Stack is empty.");

            T item = Top.Data;

            Top = Top.Next;

            return item;
        }

        public void Push(T data)
        {
            StackNode<T> node = new StackNode<T>(data);

            node.Next = Top;
            Top = node;
        }

        public T Peek()
        {
            if (Top == null) throw new InvalidOperationException("Stack is empty.");

            return Top.Data;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }

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