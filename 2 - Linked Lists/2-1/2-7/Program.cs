using LinkedList;
using System;

namespace _2_7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list1 = new SinglyLinkedList<int>();
            var list2 = new SinglyLinkedList<int>();

            var n1 = new Node<int>(1);
            var n2 = new Node<int>(2);
            var n3 = new Node<int>(3);
            var n4 = new Node<int>(4);
            var n5 = new Node<int>(5);
            var n6 = new Node<int>(6);

            list1.Add(n1);
            list1.Add(n2);
            list1.Add(n3);

            list2.Add(n4);
            list2.Add(n5);
            list2.Add(n1);

            // True
            Console.WriteLine(CheckIfListHasIntersections(list1) || CheckIfListHasIntersections(list2));

            list1 = new SinglyLinkedList<int>();
            list2 = new SinglyLinkedList<int>();

            n1 = new Node<int>(1);
            n2 = new Node<int>(2);
            n3 = new Node<int>(3);
            n4 = new Node<int>(4);
            n5 = new Node<int>(5);
            n6 = new Node<int>(6);

            list1.Add(n1);
            list1.Add(n2);
            list1.Add(n3);

            list2.Add(n4);
            list2.Add(n5);
            list2.Add(n6);

            // False
            Console.WriteLine(CheckIfListHasIntersections(list1) || CheckIfListHasIntersections(list2));

            list1 = new SinglyLinkedList<int>();
            list2 = new SinglyLinkedList<int>();

            n1 = new Node<int>(1);
            n2 = new Node<int>(2);
            n3 = new Node<int>(3);
            n4 = new Node<int>(4);
            n5 = new Node<int>(5);
            n6 = new Node<int>(6);

            list1.Add(n1);
            list1.Add(n2);
            list1.Add(n3);

            list2.Add(n4);
            list2.Add(n5);

            // False
            Console.WriteLine(CheckIfListHasIntersections(list1) || CheckIfListHasIntersections(list2));
        }

        private static bool CheckIfListHasIntersections(SinglyLinkedList<int> list)
        {
            var pointer = list.Head;

            while (pointer != list.Last)
            {
                if (pointer.Visited)
                    return true;

                pointer.Visited = true;
                pointer = pointer.Next;
            }

            if (pointer.Visited)
                return true;

            pointer.Visited = true;

            return false;
        }
    }
}