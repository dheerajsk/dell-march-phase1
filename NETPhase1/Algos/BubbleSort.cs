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
            for (int i = 0; i < array.Length - 1; i++)  // n-1
            {
                // swap loop
                for (int j = 0; j < array.Length - i - 1; j++)  // n-i-1
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
        // T(n)=>  n-1(n-i-1) => n^2-n-in-i-i => n^2-n => n^2

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
