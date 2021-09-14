using System;
using System.Collections.Generic;
using System.Linq;

namespace GrokkingAlgorithms.Algorithms
{
    public class Recursion
    {
        public static int RecursionSum(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr[0];
            }
            else
            {
                int[] subArr = new int[arr.Length - 1];
                Array.Copy(arr, 1, subArr, 0, arr.Length - 1);
                return arr[0] + RecursionSum(subArr);
            }
        }

        public static int RecursionListCount(List<int> list)
        {
            if (list.Count == 1)
            {
                return 1;
            }
            else 
            {
                return 1 + RecursionListCount(list.GetRange(0, list.Count-1));
            }
        }

        public static int RecursionListMaxElement(List<int> list)
        {
            if (list.Count == 1)
            {
                return list.First();
            }
            else
            {
                var maxTail = RecursionListMaxElement(list.GetRange(0, list.Count - 1));
                return list.Last() > maxTail ? list.Last() : maxTail;
            }
        }

        public static int? RecursionBinarySearch(int[] data, int value, int low, int high)
        {
            if (low > high) 
            {
                return null;
            }

            var mid = (low + high) / 2;
            var current = data[mid];
            if (current == value)
            {
                return mid;
            }
            if (current < value)
            {
                low = mid + 1;
            }
            if (current > value)
            {
                high = mid - 1;
            }

            return RecursionBinarySearch(data, value, low, high);
        }
    }
}