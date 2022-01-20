using System;

namespace LinkedList
{
    public class DoublyLinkedList<T>
    {
        public Node<T> Head { get; private set; }

        public Node<T> Last { get; private set; }

        public int Length { get; private set; }

        public DoublyLinkedList(Node<T> head)
        {
            Head = head;
            Last = Head;
            Length = 1;
        }

        public void Add(Node<T> node)
        {
            Last.Next = node;
            node.Previous = Last;
            Last = node;
            Length++;
        }

        public void Remove(Node<T> node)
        {
            Length--;

            if (node == Head)
            {
                node.Next.Previous = null;
                Head = node.Next;
                return;
            }

            if (node == Last)
            {
                node.Previous.Next = null;
                Last = node.Previous;
                return;
            }

            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            node.Previous = null;
            node.Next = null;
        }

        public Node<T> FindByIndex(int index)
        {
            Node<T> pointer = Head;
            int currentIndex = 0;

            while (currentIndex != index && pointer != null)
            {
                pointer = pointer.Next;
                currentIndex++;
            }

            return pointer;
        }

        public void Print()
        {
            var pointer = Head;

            while (pointer != null)
            {
                Console.WriteLine(pointer.Value);
                pointer = pointer.Next;
            }
        }
    }
}