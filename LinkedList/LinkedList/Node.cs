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
            if (next == null)
                next = new Node(data);
            else
                next.Add(data);
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
        /// <param name="k"></param>        
        public void Insertatparticular(int data, int k)
        {          
               Node  temp;
            if (k == 1)
            {
                temp = new Node(data);
                temp.next = head;
                head = temp;
                return;
            }
                        
               Node p = head;
            for (int i = 1; i < k - 1 && p != null; i++)
            {
                p = p.next;
                if (p == null)
                    Console.WriteLine("" + i + "");
                else
                {
                    temp = new Node(data);
                    temp.next = p.next;
                    p.next = temp;
                }
            }

        }           
        
        //prints the list after insertion
        public void Show()
        {
            Node node = head;
            while (node.next != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            Console.WriteLine(node.data);
        }
       
        //printing the list
        public void Print()
        {
            Console.WriteLine("" + data + "");
            if (next != null)
            {
                next.Print();
            }

        }
    }
    

}
 