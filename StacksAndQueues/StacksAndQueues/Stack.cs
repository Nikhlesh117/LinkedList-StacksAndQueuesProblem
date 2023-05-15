using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node top;
        public StackPract()
        {
            top = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if (top == null) 
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;
            //Console.WriteLine(value);
        }
        public void Peek() 
        {
            if(top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("Peek :" + this.top.data);
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("Pop :" + this.top.data);
            this.top = this.top.next;
        }
        public void Display()
        {
            Node temp = top;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
