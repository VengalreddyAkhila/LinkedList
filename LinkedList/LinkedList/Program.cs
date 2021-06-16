using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linkedlist");
            //int data = Convert.ToInt32(Console.ReadLine());
            Node node = new Node(56);
            node.Add(30);
            node.Add(70);            
            node.InsertAtstart();
            node.Insertatparticular(20, 2);                
            node.Print();
            node.Show();
        }
    }
}
