using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linkedlist");
            Node node = new Node(56);
            node.next = new Node(30);
            node.next.next = new Node(70);
            node.Print();
        }
    }
}
