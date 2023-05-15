using System;
using System.Collections;
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
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            stack.Peak();
            stack.Pop();
            
            stack.Display();
            //Queue queue = new Queue();
          
            //queue.Enqueue(56);
            //queue.Enqueue(30);
            //queue.Enqueue(70);
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Display();

            LinkedList linkedList = new LinkedList();
            // Adding elements to the list
            linkedList.Add(5);
            linkedList.Add(10);
            linkedList.Add(15);

            // Displaying the list
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Linked List:");
            linkedList.Display();

            // Adding an element in reverse order
            linkedList.AddInReverseOrder(20);

            // Displaying the list again
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Linked List in Reverse Order:");
            linkedList.Display();

            // Inserting an element at a specific position
            linkedList.InsertAtMiddle(2, 25);

            // Displaying the list again
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Linked List after Insertion:");
            linkedList.Display();

            // Removing the first element
            linkedList.RemoveAtFirst();

            // Displaying the list again
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Linked List after Removing First Element:");
            linkedList.Display();
                
            // Removing the last element
            linkedList.RemoveAtLast();

            // Displaying the list again
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Linked List after Removing Last Element:");
            linkedList.Display();

            // Searching for an element in the list
            Node result = linkedList.Search(10);

            // Inserting an element after a specific value in the list
            linkedList.SearchAndInsert(15, 30);

            // Displaying the list again
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Linked List after Searching and Inserting:");
            linkedList.Display();

            // Deleting an element from the list
            linkedList.SearchAndDelete(25);

            // Displaying the list again
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Linked List after Searching and Deleting:");
            linkedList.Display();

            // Sorting the list
            linkedList.Sort(12);

            // Displaying the list again
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Linked List after Sorting:");
            linkedList.Display();

            // Getting the size of the list
            linkedList.Size();

            Console.ReadLine();

        }
    }
}
