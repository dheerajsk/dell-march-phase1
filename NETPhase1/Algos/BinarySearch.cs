using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class BinarySearch
    {
        public void Do()
        {
            int[] array = { 4, 11, 23, 45, 67, 90, 113 }; // 0, 6
            Console.WriteLine("Please enter the element to find");
            int key = Convert.ToInt32(Console.ReadLine());
            int result = Search(array, 0, array.Length - 1, key);
            if (result == -1)
            {
                Console.WriteLine("Number not found");
            }
            else
            {
                Console.WriteLine("Number found at " + result + " index");
            }
        }

        public int Search(int[] array, int left, int right, int key)
        {
            while (left <= right)
            {
                // 1. Find Mid Element
                int mid = left + (right - left) / 2; // 0+(6-0) /2=> 0+3 =3

                // 2. Check if mid is key
                if (array[mid] == key)
                {
                    return mid;
                }

                // 3. Check if key is greater than mid element
                if (array[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

    }
}
