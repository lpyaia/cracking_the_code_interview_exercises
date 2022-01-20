using LinkedList;
using System;

namespace _2_8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list1 = new SinglyLinkedList<int>();

            var n1 = new Node<int>(1);
            var n2 = new Node<int>(2);
            var n3 = new Node<int>(3);
            var n4 = new Node<int>(4);
            var n5 = new Node<int>(5);
            var n6 = new Node<int>(6);

            list1.Add(n1);
            list1.Add(n2);
            list1.Add(n3);
            list1.Add(n4);
            list1.Add(n5);
            list1.Add(n6);
            list1.Add(n2);

            var nodeLoop = LoopDetection(list1);

            // 2
            if (nodeLoop != null) Console.WriteLine(nodeLoop.Value);
            else Console.WriteLine("NULL");

            list1 = new SinglyLinkedList<int>();

            n1 = new Node<int>(1);
            n2 = new Node<int>(2);
            n3 = new Node<int>(3);
            n4 = new Node<int>(4);
            n5 = new Node<int>(5);
            n6 = new Node<int>(6);

            list1.Add(n1);
            list1.Add(n2);
            list1.Add(n3);
            list1.Add(n4);
            list1.Add(n5);
            list1.Add(n6);

            nodeLoop = LoopDetection(list1);

            // NULL
            if (nodeLoop != null) Console.WriteLine(nodeLoop.Value);
            else Console.WriteLine("NULL");
        }

        private static Node<T> LoopDetection<T>(SinglyLinkedList<T> list)
        {
            var pointer = list.Head;

            while (pointer != null && !pointer.Visited)
            {
                pointer.Visited = true;
                pointer = pointer.Next;
            }

            return pointer;
        }
    }
}