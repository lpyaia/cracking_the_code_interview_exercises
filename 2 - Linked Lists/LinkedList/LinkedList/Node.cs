namespace LinkedList
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }

        public T Value { get; }

        public bool Visited { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}