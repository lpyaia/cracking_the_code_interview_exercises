using LinkedList;
using System;

namespace _2_5_b
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n1 = new Node<int>(6);
            var n2 = new Node<int>(1);
            var n3 = new Node<int>(7);

            var lst1 = new SinglyLinkedList<int>(n1);
            lst1.Add(n2);
            lst1.Add(n3);

            var n21 = new Node<int>(2);
            var n22 = new Node<int>(9);
            var n23 = new Node<int>(5);

            var lst2 = new SinglyLinkedList<int>(n21);
            lst2.Add(n22);
            lst2.Add(n23);

            SumLists(lst1, lst2).Print();
        }

        private static SinglyLinkedList<int> SumLists(SinglyLinkedList<int> l1, SinglyLinkedList<int> l2)
        {
            int result = ConvertListToInteger(l1) + ConvertListToInteger(l2);
            var summedList = new SinglyLinkedList<int>();

            while (result > 0)
            {
                var digit = result % 10;
                result = result / 10;

                var node = new Node<int>(digit);
                summedList.AddToBeginning(node);
            }

            return summedList;
        }

        private static int ConvertListToInteger(SinglyLinkedList<int> list)
        {
            Node<int> pointer = list.Head;
            int decimalPlaces = (int)Math.Pow(10, (double)list.Length - 1);
            int convertedInteger = 0;

            while (pointer != null)
            {
                convertedInteger += pointer.Value * decimalPlaces;
                decimalPlaces /= 10;

                pointer = pointer.Next;
            }

            return convertedInteger;
        }
    }
}