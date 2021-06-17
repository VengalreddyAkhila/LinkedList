using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linkedlist");
           
            Node node = new Node(56);
            node.Add(30);
            node.Add(70);
            node.InsertAtstart();
            node.Insertatparticular(90, 2);
            node.Insertatparticular(10, 1);
            Console.WriteLine("after Inserted new list");
            node.Display();
            node.Deletefirst();
            node.Deletelast();
            Console.WriteLine("after deleted new lsit:");
            node.Display();
            node.Search(30);
        }
    }
}
