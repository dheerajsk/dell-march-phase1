using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class MergeSort
    {
        public void Do()
        {
            int[] array = { 45, 81, 13, 20, 32, 97, 4 };
            Divide(array, 0, array.Length - 1);
        }

        // Creating pointers for left and right array
        void Divide(int[] arr, int left, int right) // n*logn => nlogn<n^2
        {
            if (left < right)
            {

                int mid = left + (right - left) / 2;
                // Get left array
                Divide(arr, left, mid);
                // Get right array
                Divide(arr, mid + 1, right);
                MergeAndSort(arr, left, mid, right);
            }
        }

        void MergeAndSort(int[] arr, int left, int mid, int right) // 3n=> n
        {
            //1. Create Left and Right array.

            // 1.1 Length of arrays.
            int leftArrayLength = mid - left + 1;// => 3 - 0 +1 => 4
            int rightArrayLenth = right - mid; // 6 - 3 =3

            // Create left and right array
            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLenth];

            // Copy values in right and left array.
            int i = 0, j = 0;
            for (i = 0; i < leftArrayLength; i++) // n
            {
                leftArray[i] = arr[left + i];
            }
            for (j = 0; j < rightArrayLenth; j++) // n
            {
                rightArray[j] = arr[mid + 1 + j];
            }

            // 2. Sort & Merge
            i = 0; j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLenth) // n
            {
                if (leftArray[i] < rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            // Copy remaining values
            while (i < leftArrayLength)
            {
                arr[k] = leftArray[i];
                k++;
                i++;
            }
            while (j < rightArrayLenth)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }
            Print(arr);
        }

        void Print(int[] array)
        {
            foreach(int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
