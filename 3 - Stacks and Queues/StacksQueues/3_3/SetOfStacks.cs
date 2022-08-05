namespace _3_3
{
    public class SetOfStacks<T>
    {
        private readonly List<Stack<T>> _setOfStacks;

        private Stack<T>? _topStack;

        public int StackSize { get; private set; }

        public SetOfStacks(int stackSize)
        {
            _setOfStacks = new List<Stack<T>>();
            StackSize = stackSize;
        }

        public bool IsEmpty() => !_setOfStacks.Any();

        public void Push(T data)
        {
            if (!_setOfStacks.Any() || _topStack!.IsFull())
            {
                _topStack = new Stack<T>(StackSize);
                _setOfStacks.Add(_topStack);
            }

            Console.WriteLine($"Pushing into stack: {_setOfStacks.Count}");

            _topStack.Push(data);
        }

        public T? Pop()
        {
            if (_topStack is null) return default;

            if (_topStack.IsEmpty())
            {
                _setOfStacks.Remove(_topStack);
                _topStack = _setOfStacks.LastOrDefault();
            }

            if (_topStack is null) return default;

            Console.WriteLine($"Poping into stack: {_setOfStacks.Count}");

            return _topStack.Pop();
        }

        public T? PopAt(int index)
        {
            if (!IsEmpty())
            {
                Stack<T>? stack = _setOfStacks.ElementAtOrDefault(index);

                if (stack is null) return default;

                Console.WriteLine($"Poping into stack: {index + 1}");

                return stack.Pop();
            }

            return default;
        }
    }
}