using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues
{
    public class Queue<T>
    {
        public QueueNode<T>? First { get; set; } = default!;
        public QueueNode<T>? Last { get; set; } = default!;

        public void Add(T value)
        {
            var node = new QueueNode<T>(value);

            if (Last != null)
                Last.Next = node;

            Last = node;

            if (First == null)
                First = Last;
        }

        public T Remove()
        {
            if (First == null) throw new InvalidOperationException("Queue is empty!");

            var value = First.Value;

            First = First.Next;

            if (First == null)
                Last = null;

            return value;
        }

        public T Peek()
        {
            if (First == null) throw new InvalidOperationException("Queue is empty!");

            return First.Value;
        }

        public bool IsEmpty()
        {
            return First == null;
        }
    }

    public class QueueNode<T>
    {
        public T Value { get; set; }

        public QueueNode<T>? Next { get; set; }

        public QueueNode(T value)
        {
            Value = value;
        }
    }
}