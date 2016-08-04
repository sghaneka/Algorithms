using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public static class SortingUtils
    {
        public static void BubbleSort(int[] arrayToSort)
        {
            bool swapped = false;
            while (!swapped)
            {
                for (int i = 1; i < arrayToSort.Length; i++)
                {
                    if (arrayToSort[i - 1] > arrayToSort[i])
                    {
                        int tmp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i - 1];
                        arrayToSort[i - 1] = tmp;
                    }
                }
            }

        }

        public static void InsertionSort(int[] arrayToSort)
        {
            int endPos = 0;
            for (int i=1; i<arrayToSort.Length; i++)
            {
                int tmpNum = arrayToSort[i];
                int idx = i;                
                for (int x = endPos; x>=0; x--)
                {
                    if (tmpNum < arrayToSort[x])
                    {
                        arrayToSort[idx] = arrayToSort[x];
                        idx--;
                        if (idx == 0)
                        {
                            arrayToSort[idx] = tmpNum;
                        }
                    }
                    else
                    {
                        arrayToSort[idx] = tmpNum;
                        break;
                    }                                       
                }
                endPos++;
            }
        }

        public static void BubbleSortPractice(int [] arrayToSort)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        swap(ref arrayToSort[i], ref arrayToSort[i + 1]);
                        swapped = true;
                    }
                }
            }

        }

        public static void swap<T>(ref T a, ref T b)
        {
            T tmp = b;
            b = a;
            a = tmp;
        }
    }
}
