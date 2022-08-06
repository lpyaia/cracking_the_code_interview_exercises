namespace _3_4
{
    public class MyQueue<T>
    {
        private readonly Stack<T> _stack1;

        private readonly Stack<T> _stack2;

        public MyQueue()
        {
            _stack1 = new Stack<T>();
            _stack2 = new Stack<T>();
        }

        public void Queue(T value)
        {
            while (!_stack2.IsEmpty())
            {
                _stack1.Push(_stack2.Pop());
            }

            Console.WriteLine($"Queueing: {value}");

            _stack1.Push(value);
        }

        public T Unqueue()
        {
            while (!_stack1.IsEmpty())
            {
                _stack2.Push(_stack1.Pop());
            }

            T value = _stack2.Pop();

            Console.WriteLine($"Unqueing: {value}");

            return value;
        }
    }
}