using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    public static class SearchUtils
    {

        public static int BinarySearch(int value, int[] arr)
        {
            int lower, upper, mid;
            // Assume array is sorted
            lower = 0;
            upper = arr.Length - 1;
            while (lower <= upper)
            {
                mid = (upper + lower) / 2;

                if (arr[mid] == value)
                    return mid;

                if (value < arr[mid])
                    upper = mid - 1;
                else
                {
                    lower = mid + 1;
                }
            }
            return 1;
        }

        public static int RbinSearch(int value, int lower, int upper, int[] arr)
        {
            if (arr[upper] == value) return upper;
            else if (lower == upper)
                return -1;
            else {
                int mid;
                mid = (int)(upper + lower) / 2;
                if (value < arr[mid])
                    return RbinSearch(value, lower, mid - 1, arr);
                else if (value == arr[mid])
                    return mid;
                else
                    return RbinSearch(value, mid + 1, upper, arr);
            }
        }

        public static bool BinarySearchTest(int value, int[] arr)
        {
            // searching for value in sorted array arr
            // take midpoint of range
            int lowRange = 0;
            int highRange = arr.Length - 1;
            int midPoint;

            while (lowRange != highRange)
            {
                midPoint = (highRange + lowRange) / 2;
                if (arr[midPoint] == value)
                    return true;

                if (arr[midPoint] < value)
                {
                    lowRange = midPoint + 1;
                }
                else
                {
                    highRange = midPoint - 1;
                }
            }
            return false;
        }
    }
}