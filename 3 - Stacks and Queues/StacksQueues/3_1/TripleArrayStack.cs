namespace _3_1
{
    public class TripleArrayStack<T>
    {
        public int SizeStackOne { get; private set; }
        public int SizeStackTwo { get; private set; }
        public int SizeStackThree { get; private set; }
        public int CurrentPositionStackOne { get; private set; }
        public int CurrentPositionStackTwo { get; private set; }
        public int CurrentPositionStackThree { get; private set; }
        public int FirstPositionStackOne { get; private set; }
        public int FirstPositionStackTwo { get; private set; }
        public int FirstPositionStackThree { get; private set; }
        public T?[] Queue { get; private set; }

        public TripleArrayStack(int sizeStackOne, int sizeStackTwo, int sizeStackThree)
        {
            SizeStackOne = sizeStackOne;
            SizeStackTwo = sizeStackTwo;
            SizeStackThree = sizeStackThree;

            FirstPositionStackOne = 0;
            FirstPositionStackTwo = SizeStackOne;
            FirstPositionStackThree = SizeStackOne + SizeStackTwo;

            CurrentPositionStackOne = CurrentPositionStackTwo = CurrentPositionStackThree = -1;

            Queue = new T?[SizeStackOne + SizeStackTwo + SizeStackThree];

            Array.Fill(Queue, default);
        }

        public bool IsStackOneEmpty()
        {
            return Queue[FirstPositionStackOne] == null;
        }

        public bool IsStackTwoEmpty()
        {
            return Queue[FirstPositionStackTwo] == null;
        }

        public bool IsStackThreeEmpty()
        {
            return Queue[FirstPositionStackThree] == null;
        }

        public void PushItemInStackOne(T item)
        {
            if (CurrentPositionStackOne == SizeStackOne + FirstPositionStackOne - 1)
                throw new StackOverflowException("Bam! Stack One Overflowed!");

            if (Queue[FirstPositionStackOne] == null)
            {
                Queue[FirstPositionStackOne] = item;
                CurrentPositionStackOne = FirstPositionStackOne;
            }

            else
            {
                Queue[++CurrentPositionStackOne] = item;
            }
        }

        public void PushItemInStackTwo(T item)
        {
            if (CurrentPositionStackTwo == SizeStackTwo + FirstPositionStackTwo - 1)
                throw new StackOverflowException("Bam! Stack Two Overflowed!");

            if (Queue[FirstPositionStackTwo] == null)
            {
                Queue[FirstPositionStackTwo] = item;
                CurrentPositionStackTwo = FirstPositionStackTwo;
            }

            else
            {
                Queue[++CurrentPositionStackTwo] = item;
            }
        }

        public void PushItemInStackThree(T item)
        {
            if (CurrentPositionStackThree == SizeStackThree + FirstPositionStackThree - 1)
                throw new StackOverflowException("Bam! Stack Three Overflowed!");

            if (Queue[FirstPositionStackThree] == null)
            {
                Queue[FirstPositionStackThree] = item;
                CurrentPositionStackThree = FirstPositionStackThree;
            }

            else
            {
                Queue[++CurrentPositionStackThree] = item;
            }
        }

        public T PopFromStackOne()
        {
            if (IsStackOneEmpty())
                throw new InvalidOperationException("Stack One is empty");

            var item = Queue[CurrentPositionStackOne];

            Queue[CurrentPositionStackOne--] = default;

            return item!;
        }

        public T PopFromStackTwo()
        {
            if (IsStackTwoEmpty())
                throw new InvalidOperationException("Stack Two is empty");

            var item = Queue[CurrentPositionStackTwo];

            Queue[CurrentPositionStackTwo--] = default;

            return item!;
        }

        public T PopFromStackThree()
        {
            if (IsStackTwoEmpty())
                throw new InvalidOperationException("Stack Three is empty");

            var item = Queue[CurrentPositionStackThree];

            Queue[CurrentPositionStackThree--] = default;

            return item!;
        }

        public T PeekStackOne()
        {
            if (IsStackOneEmpty())
                throw new InvalidOperationException("Stack One is empty");

            return Queue[CurrentPositionStackOne]!;
        }

        public T PeekStackTwo()
        {
            if (IsStackTwoEmpty())
                throw new InvalidOperationException("Stack Two is empty");

            return Queue[CurrentPositionStackTwo]!;
        }

        public T PeekStackThree()
        {
            if (IsStackThreeEmpty())
                throw new InvalidOperationException("Stack Three is empty");

            return Queue[CurrentPositionStackThree]!;
        }
    }
}