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
        public void Push(int data)
        {
            Node node = new Node(data);

            if (this.top == null)
            {
                this.top = node;
            }
            else
            {
                node.next = this.top;
                this.top = node;
            }
            Console.WriteLine("{0} Pushed into stack", node.data);
        }
        public void Peak()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the Peak of the stack  ", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peak();
                Pop();
            }
        }
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
