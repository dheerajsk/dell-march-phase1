using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Strcuture
{
    class Queue
    {
        int[] array;
        int maxSize;
        int frontPointer;
        int rearPointer;

        public void Do()
        {

            Queue q = new Queue();

            q.maxSize = 5;
            q.array = new int[5];
            q.frontPointer = -1;
            q.rearPointer = -1;
            // 2, 24, 69, 32, 60
            q.Insert(2);
            q.Insert(24);
            q.Insert(69);
            q.Print();
            q.Delete();
            q.Delete();
            q.Print();
            q.Insert(32);
            q.Insert(60);
            q.Print();


        }

        void Insert(int num)
        {
            // check if queue is full.
            if (frontPointer == 0 && rearPointer == maxSize - 1)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                if (frontPointer == -1)
                {
                    frontPointer = 0;
                }
                rearPointer = rearPointer + 1;
                array[rearPointer] = num;
                Console.WriteLine(num + " is inserted in Q");
            }
        }

        int Delete()
        {
            if (frontPointer == -1)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                int element = array[frontPointer];
                if (frontPointer >= rearPointer)
                {
                    frontPointer = -1;
                    rearPointer = -1;
                }
                else
                {
                    frontPointer++;
                }
                Console.WriteLine(element + " is deleted from Q");
                return element;
            }
        }

        void Print()
        {
            if (this.frontPointer == -1)
            {
                Console.WriteLine("Queue is empty");
            }
            for (int i = frontPointer; i <= rearPointer; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.Write("\n");
        }
    }
}
