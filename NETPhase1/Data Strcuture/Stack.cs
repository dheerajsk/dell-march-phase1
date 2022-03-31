using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Strcuture
{
    class Stack
    {
        int[] array;
        int topPointer = -1;
        int maxSize;

        public void Do()
        {
            // 12, 24, 21, 93, 87
            Console.WriteLine("Printing Initial Stack");
            Print();
            // Push
            Stack stack = new Stack();
            stack.maxSize = 5; // 4
            stack.array = new int[5];

            Console.WriteLine("Pushing into Stack");
            stack.Push(12);
            stack.Push(24);
            stack.Push(21);
            Console.WriteLine("Printing Stack");
            stack.Print();
            Console.WriteLine("Peeking into Stack");
            Console.WriteLine(stack.Peek());
            Console.WriteLine("Pop from Stack");
            stack.Pop();
            stack.Pop();
            Console.WriteLine("Printing Stack");
            stack.Print();
            stack.Push(93);
            stack.Push(87);
            Console.WriteLine("Printing Stack");
            stack.Print();
        }

        void Push(int num)
        {
            // Check if stack is full.
            if (this.topPointer == this.maxSize - 1)
            {
                Console.WriteLine("Stack is Full");
            }
            else
            {
                // Increase pointer and add item in stack.
                this.topPointer = this.topPointer + 1;
                array[this.topPointer] = num;
            }
        }

        int Pop()
        {
            // Check if stack is empty.
            if (topPointer == -1)
            {
                Console.WriteLine("Stack is empty.");
                return -1;
            }
            else
            {
                int element = array[topPointer];
                topPointer--;
                return element;
            }
        }

        int Peek()
        {
            // Check if stack is empty.
            if (topPointer == -1)
            {
                Console.WriteLine("Stack is empty.");
                return -1;
            }
            else
            {
                int element = array[topPointer];
                return element;
            }
        }

        void Print()
        {
            if (this.topPointer == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            for (int i = topPointer; i >=0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
