using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkeddList
{
    public class LinkeddList
    {
        internal Node head;
        
        //addNode() will add a new node to the list
        public void Add(int data)
        {
            //Creat a new node 
            Node node = new Node(data);
            //Checks if the list is empty
            if(head == null)
            {
                //if list is empty,head will point to new node
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
            Console.WriteLine($"{node.data} is Inserted in Linked List\n");
        }
        public void Insert_front(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }
        public void Insert_Last(int data)
        {
            Node newNode = new Node(data);
            newNode.next = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node(data);
                temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newNode;
            }
        }
       
       public void Display()
        {
            int i = 1;
            Node temp = head;

            if (temp == null)
            {
                Console.WriteLine("LinkeddList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($"Element {i} in Linked List is : " + temp.data);
                temp = temp.next;
                i++;
            }
        }
    }
}
