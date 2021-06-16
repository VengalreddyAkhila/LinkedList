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
        public Node(int i)
        {
            data = i;
            next = null;
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
 