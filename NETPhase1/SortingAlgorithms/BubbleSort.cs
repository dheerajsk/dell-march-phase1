using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class BubbleSort
    {
        public void Do()
        {
            int[] array = { 23, 17, 96, 4, 41, 11 };
            Sort(array);
        }

        public void Sort(int[] array)
        {
            // iteration loop
            for (int i = 0; i < array.Length - 1; i++)
            {
                // swap loop
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                Console.WriteLine("After " + i + 1 + " iteration");
                Print(array);
            }
        }

        public void Print(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
    }
}
