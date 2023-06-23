using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Alogos;

namespace Algorithms.Alogos
{
    class SeachingAlgorithm
    {
        #region Linear Search

        internal static void LinearSerch()
        {
            int _arrSize = FindNumber.getArrSize();
            int[] arr = new int[_arrSize];
            arr = FindNumber.getArray(_arrSize);
            int _elementToFind = FindNumber.elementToFind();
            string res = "";

            for (int i = 0; i < _arrSize; i++)
            {
                if (arr[i] == _elementToFind)
                {
                    res = "Element Found";
                    Console.WriteLine(res);
                    break;
                }
            }
            if (res == "") Console.WriteLine("Element not Found");

            Console.ReadKey();
        }

        #endregion

        #region Binary Search
        internal static void MainForBinarySearch()
        {
            int _arrSize = FindNumber.getArrSize();
            int[] arr = new int[_arrSize];
            arr = FindNumber.getArray(_arrSize);
            int _elementToFind = FindNumber.elementToFind();
            
            int i = BinarySearch(arr, 0, _arrSize, _elementToFind);
            
            if (i == -1)
                Console.WriteLine("Element not Found");
            else
                Console.WriteLine("Element Found at {0} element of the array", i);
            Console.ReadKey();
        }

        private static int BinarySearch(int[] arr, int left,int right, int elementToFind)
        {
            if(left <= right)
            {
                int mid = left + (right - 1) / 2;

                if(arr[mid] == elementToFind)
                {
                    return mid;
                }
                if (arr[mid] > elementToFind)
                {
                    return BinarySearch(arr, left, mid - 1, elementToFind);
                }
                if(arr[mid] < elementToFind)
                {
                    return BinarySearch(arr, mid + 1, right, elementToFind);
                }
            }
            return -1;            
        }

        #endregion

        #region Jump Search
        internal static void MainforJumpSearch()
        {
            Console.WriteLine("-------------Welcome to JumpSort Example------------\n");
            int _arrSize = FindNumber.getArrSize();
            int[] arr = new int[_arrSize];
            arr = FindNumber.getArray(_arrSize, "Please enter a sorted array for Jump sort of size");
            int _elementToFind = FindNumber.elementToFind();

            int indexof_elementToFind = JumpSearch(arr, _elementToFind);

            if (indexof_elementToFind == -1)
                Console.WriteLine("Element not Found");
            else
                Console.WriteLine("Element Found at {0} element of the array", indexof_elementToFind);
            Console.ReadKey();
        }

        private static int JumpSearch(int[] arr, int _elementToFind)
        {
            int arrSize = arr.Length;

            int prev = 0;

            int step = (int)Math.Floor(Math.Sqrt(arrSize));
            while(arr[Math.Min(step, arrSize)-1] < _elementToFind)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(arrSize));

                if (prev >= arrSize)
                    return -1;
            }

            while (arr[prev] < _elementToFind)
            {
                prev++;
                if(prev == Math.Min(step, arrSize))
                {
                    return -1;
                }
            }

            if(arr[prev] == _elementToFind)
            {
                return prev;
            }

            return -1;           
        }

        #endregion
    }
}
