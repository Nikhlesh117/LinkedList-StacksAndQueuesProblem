﻿using System;
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

            stack.IsEmpty();
            stack.Display();
            Console.ReadLine();
        }
    }
}