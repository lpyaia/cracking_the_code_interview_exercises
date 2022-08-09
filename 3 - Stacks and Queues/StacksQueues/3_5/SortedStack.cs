namespace _3_5
{
    public class SortedStack
    {
        private readonly Stack<int> _stack1;

        private readonly Stack<int> _stack2;

        public SortedStack()
        {
            _stack1 = new Stack<int>();
            _stack2 = new Stack<int>();
        }

        public void Push(int value)
        {
            while (!_stack1.IsEmpty() && _stack1.Peek() <= value)
            {
                _stack2.Push(_stack1.Pop());
            }

            _stack1.Push(value);

            while (!_stack2.IsEmpty())
            {
                _stack1.Push(_stack2.Pop());
            }
        }

        public int? Pop()
        {
            if (_stack1.IsEmpty())
                return null;

            return _stack1.Pop();
        }
    }
}