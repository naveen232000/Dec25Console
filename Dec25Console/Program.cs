using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec25Console
{
  public class LinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
       public void push(int new_data)
        {
            
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
            Console.WriteLine(new_node.data);
          
        }
        static void Main(string[] args)
        {
            LinkedList Sll = new LinkedList();
            Sll.push(11);
            Sll.push(56);
            Sll.push(45);

          
            Console.ReadLine();
        }
    }
}
