namespace _3_1
{
    public class TripleStack<T>
    {
        public int Size { get; private set; }

        public int[] CurrentPosition { get; private set; }

        public int[] FirstPosition { get; private set; }

        public T?[] Queue { get; private set; }

        public TripleStack(int size)
        {
            Size = size;

            FirstPosition = new int[] { 0, size, size * 2 };
            CurrentPosition = new int[] { -1, -1, -1 };

            Queue = new T?[Size * 3];

            Array.Fill(Queue, default);
        }

        public bool IsEmpty(int index)
        {
            return Queue[Size * index] == null;
        }

        public void Push(T item, int index)
        {
            if (CurrentPosition[index] == Size + FirstPosition[index] - 1)
                throw new StackOverflowException($"Bam! Stack {index + 1} Overflowed!");

            if (Queue[FirstPosition[index]] == null)
            {
                Queue[FirstPosition[index]] = item;
                CurrentPosition[index] = FirstPosition[index];
            }

            else
            {
                Queue[++CurrentPosition[index]] = item;
            }
        }

        public T Pop(int index)
        {
            if (IsEmpty(index))
                throw new InvalidOperationException("Stack One is empty");

            var item = Queue[CurrentPosition[index]];

            Queue[CurrentPosition[index]--] = default;

            return item!;
        }

        public T Peek(int index)
        {
            if (IsEmpty(index))
                throw new InvalidOperationException("Stack One is empty");

            return Queue[CurrentPosition[index]]!;
        }
    }
}