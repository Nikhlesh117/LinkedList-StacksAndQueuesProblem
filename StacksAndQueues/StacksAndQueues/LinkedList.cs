using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class LinkedList
    {
        public Node head; //Empty node
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {

                Node temp = head; // storeing last data in temp variable
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} LinkedList", node.data);
        }
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = head;
                head = newNode;
                head.next = temp;
            }
            Console.WriteLine("{0} reverse order LinkedList", newNode.data);

        }

        public Node InsertAtMiddle(int position, int data)
        {
            Node newNode = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid Position!");

            if (position == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
            return head;
        }
        //Pop at first
        public void RemoveAtFirst()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            this.head = this.head.next;
            Console.WriteLine("First element deleted successfully");
        }
        public void RemoveAtLast()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            Node lastNode = this.head;
            while (lastNode.next.next != null)
            {
                lastNode = lastNode.next;
            }
            lastNode.next = null;
        }
        public Node Search(int data)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    Console.WriteLine("Given value: " + data + " is in Linked List");
                    return temp;
                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Given value: " + data + " is not in Linked List");
            }
            return null;
        }
        public void SearchAndInsert(int position, int data)
        {
            Node temp = this.head;
            Node newNode = new Node(data);

            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }

            while (temp.next != null)
            {
                if (temp.data == position)
                {
                    Console.WriteLine(newNode.data + " is inserted after " + temp.data);
                    newNode.next = temp.next;
                    temp.next = newNode;
                    break;
                }
                temp = temp.next;
            }
        }
        public void SearchAndDelete(int data)
        {
            Node temp = head;

            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp.next != null)
            {
                if (temp.next.data == data)
                {
                    temp.next = temp.next.next;
                    Console.WriteLine("The value " + data + " is deleted from the Linked List");
                }
                temp = temp.next;
            }
        }
        public void Sort(int value)
        {
            Node newNode = new Node(value);

            if (head == null || value < head.data)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null && current.next.data < value)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
            }
        }
        public void Size()
        {
            Node temp = head;//Storing data in a varible 
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp.next != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Count will be " + count);
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }


    }

}
