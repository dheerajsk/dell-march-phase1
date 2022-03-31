using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class LinearSearch
    {
        public void Search()
        {
            int[] array = { 4, 15, 90, 43, 12, 53, 76, 21, 3 }; // 9 // 8

            Console.WriteLine("Please enter the element to find");
            int num = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    found = true;
                    Console.WriteLine(num + " found at " + i + " index");
                    break; // breaks the loop
                }
            }
            if (!found)
            {
                Console.WriteLine("Number not found");
            }
        }
    }
}
