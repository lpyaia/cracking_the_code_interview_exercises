using LinkedList;
using System;

namespace _2_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n1 = new Node<char>('F');
            var n2 = new Node<char>('O');
            var n3 = new Node<char>('L');
            var n4 = new Node<char>('L');
            var n5 = new Node<char>('O');
            var n6 = new Node<char>('W');
            var n7 = new Node<char>(' ');
            var n8 = new Node<char>('U');
            var n9 = new Node<char>('P');

            var lst = new SinglyLinkedList<char>(n1);
            lst.Add(n2);
            lst.Add(n3);
            lst.Add(n4);
            lst.Add(n5);
            lst.Add(n6);
            lst.Add(n7);
            lst.Add(n8);
            lst.Add(n9);

            // F
            Console.WriteLine(lst.FindByIndex(0).Value);

            // W
            Console.WriteLine(lst.FindByIndex(5).Value);

            // P
            Console.WriteLine(lst.FindByIndex(8).Value);
        }
    }
}