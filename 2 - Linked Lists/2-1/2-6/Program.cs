using LinkedList;
using System;

namespace _2_6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new SinglyLinkedList<char>();

            var n1 = new Node<char>('K');
            var n2 = new Node<char>('A');
            var n3 = new Node<char>('I');
            var n4 = new Node<char>('A');
            var n5 = new Node<char>('K');

            list.Add(n1);
            list.Add(n2);
            list.Add(n3);
            list.Add(n4);
            list.Add(n5);

            // True
            Console.WriteLine(IsPalindrome(list));

            list = new SinglyLinkedList<char>();

            n1 = new Node<char>('E');
            n2 = new Node<char>('S');
            n3 = new Node<char>('S');
            n4 = new Node<char>('E');

            list.Add(n1);
            list.Add(n2);
            list.Add(n3);
            list.Add(n4);

            // True
            Console.WriteLine(IsPalindrome(list));

            list = new SinglyLinkedList<char>();

            n1 = new Node<char>('A');
            n2 = new Node<char>('U');
            n3 = new Node<char>('L');
            n4 = new Node<char>('A');

            list.Add(n1);
            list.Add(n2);
            list.Add(n3);
            list.Add(n4);

            // False
            Console.WriteLine(IsPalindrome(list));
        }

        private static bool IsPalindrome(SinglyLinkedList<char> list)
        {
            int rightSidePointerPosition = list.Length;
            int leftSidePointerPosition = 1;
            int quantitySteps = rightSidePointerPosition - leftSidePointerPosition;
            Node<char> leftSidePointer = list.Head;
            Node<char> rightSidePointer = leftSidePointer;

            while (quantitySteps > 0 && leftSidePointer != null)
            {
                for (int i = 0; i < quantitySteps; i++)
                    rightSidePointer = rightSidePointer.Next;

                if (rightSidePointer.Value != leftSidePointer.Value)
                    return false;

                leftSidePointerPosition++;
                rightSidePointerPosition--;

                leftSidePointer = leftSidePointer.Next;
                rightSidePointer = leftSidePointer;

                quantitySteps = rightSidePointerPosition - leftSidePointerPosition;
            }

            return true;
        }
    }
}