using System;

namespace LinkedList
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; private set; }

        public Node<T> Last { get; private set; }

        public int Length { get; private set; }

        public SinglyLinkedList()
        {
        }

        public SinglyLinkedList(Node<T> head)
        {
            Head = head;
            Last = Head;
            Length = 1;
        }

        public void Add(Node<T> node)
        {
            if (Head == null)
            {
                Last = Head = node;
                Length++;
                return;
            }

            Last.Next = node;
            Last = node;
            Length++;
        }

        public void AddToBeginning(Node<T> node)
        {
            node.Next = Head;
            Head = node;
        }

        public void Remove(Node<T> node)
        {
            Length--;

            if (node == Head)
            {
                Head = node.Next;
                return;
            }

            var currentNode = Head;

            while (currentNode.Next != node)
            {
                currentNode = currentNode.Next;
            }

            if (node == Last)
                Last = currentNode;

            currentNode.Next = node.Next;
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
            Node<T> pointer = Head;

            while (pointer != null)
            {
                Console.Write(pointer.Value);
                pointer = pointer.Next;
            }
        }
    }
}