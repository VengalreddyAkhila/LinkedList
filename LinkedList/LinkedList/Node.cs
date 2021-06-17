using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    /// <summary>
    /// creating the list 
    /// </summary>

    public class Node
    {
        public int data;
        public Node next;
        private Node head;
        public Node(int i)
        {

            data = i;
            next = null;
            head = null;
        }
        /// <summary>
        /// Adding the data to list
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        /// <summary>
        /// inserts the data at starting position in list
        /// </summary>
        public void InsertAtstart()
        {
            Node temp = new Node(data);
            temp.next = head;
            head = temp;
        }
        /// <summary>
        /// inserts the data at particulat position
        /// </summary>
        /// <param name="data"></param>
        /// <param name="position"></param>        
        public void Insertatparticular(int data, int position)
        {
            Node temp = new Node(data);
            temp.next = null;
            Node p = head;
            for (int i = 1; i < position - 1; i++)
            {
                p = p.next;

            }
            temp.next = p.next;
            p.next = temp;
        }
        /// <summary>
        /// prints the list
        /// </summary>
        public void Display()
        {
            Node p = head;
            while (p != null)
            {
                Console.WriteLine(p.data);
                p = p.next;
            }
        }
        /// <summary>
        /// deletes the first node in list
        /// </summary>
        public void Deletefirst()
        {
            if (head == null)
                return;
            head = head.next;
        }
        /// <summary>
        /// deletes the last node in list
        /// </summary>
        public void Deletelast()
        {
            if (head == null)
                Console.WriteLine("the list is empty");

            if (head.next == null)
            {
                head = null;
                return;
            }
            Node p = head;
            while (p.next.next != null)
            {
                p = p.next;
            }
            p.next = null;

        }
    }
}
    

        

    
    


 