using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourIndexNumber
{
    public class BinarySearch
    {
        // function to sort the array
        public int[] SortInputs(int[] inputs)
        {
            // sort the array
            Array.Sort(inputs);

            // Print the sorted array
            Console.Write("\nThe sorted array is : ");
            Console.Write("[ ");
            foreach (int i in inputs)
            {
                Console.Write(+i + " ");
            }
            Console.Write("]\n");

            return inputs;
        }

        public int RecursiveBinarySearch(int[] inputs, int target, int start, int end)
        {

            if (start > end)
            {
                return -1;
            }

            //calculate the mid
            int mid = (start + end) / 2;
            if (inputs[mid] == target)
            {
                return mid;
            }
            else if (inputs[mid] > target)
            {
                return this.RecursiveBinarySearch(inputs, target, start, mid - 1);
            }
            else
            {
                return this.RecursiveBinarySearch(inputs, target, mid + 1, end);
            }
        }

        public int IterativeBinarySearch(int[] inputs, int target)
        {

            int start = 0;
            int end = inputs.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (inputs[mid] == target)
                {
                    return mid;
                }
                else if (inputs[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return -1;
        }
    }
}


