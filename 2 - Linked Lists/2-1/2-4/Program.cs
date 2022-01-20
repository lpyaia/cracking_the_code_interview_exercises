using LinkedList;
using System;

namespace _2_4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n1 = new Node<int>(3);
            var n2 = new Node<int>(5);
            var n3 = new Node<int>(8);
            var n4 = new Node<int>(5);
            var n5 = new Node<int>(10);
            var n6 = new Node<int>(2);
            var n7 = new Node<int>(1);

            var lst = new DoublyLinkedList<int>(n1);
            lst.Add(n2);
            lst.Add(n3);
            lst.Add(n4);
            lst.Add(n5);
            lst.Add(n6);
            lst.Add(n7);

            PartitionBy(lst, 5);

            lst.Print();
        }

        private static void PartitionBy(DoublyLinkedList<int> list, int x)
        {
            var pointer1 = list.Head;
            var lastLessThanX = pointer1;

            while (pointer1 != null)
            {
                if (pointer1.Value < x && pointer1 != lastLessThanX)
                {
                    var lastLessThanXNext = lastLessThanX.Next;
                    var nextPointer1 = pointer1.Next;

                    if (nextPointer1 != null) // last element
                        nextPointer1.Previous = pointer1.Previous;

                    lastLessThanX.Next = pointer1;
                    pointer1.Previous.Next = pointer1.Next;
                    pointer1.Next = lastLessThanXNext;
                    pointer1.Previous = lastLessThanX;
                    lastLessThanX = pointer1;
                    pointer1 = nextPointer1;
                }

                else pointer1 = pointer1.Next;
            }
        }
    }
}