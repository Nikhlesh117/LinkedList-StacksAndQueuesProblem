using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Stack stack = new Stack();
            //stack.Push(70);
            //stack.Push(30);
            //stack.Push(56);

UC1_StackPushAndPop
            stack.Peak();
            stack.Pop();
            
            stack.Display();

            //stack.Peak();
            //stack.Pop();

            //stack.Display();

            Queue queue = new Queue();

            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Display();

            Console.ReadLine();
        }
    }
}
