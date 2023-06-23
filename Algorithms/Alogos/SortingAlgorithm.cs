using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Alogos;

namespace Algorithms.Alogos
{
    class SortingAlgorithm
    {
        #region Selection Sort
        internal static void MainforSelectionSort()
        {
            int _arrSize = FindNumber.getArrSize();
            int[] arr = new int[_arrSize];
            arr = FindNumber.getArray(_arrSize);

            arr = SelectionSort(arr);

            FindNumber.PrintOneDArrayInOneLine("Finally the array is: ", arr);

            Console.WriteLine("Time Complexity: O(n2) as there are two nested loops.");
        }

        private static int[] SelectionSort(int[] arr)
        {
            int arrSize = arr.Length;

            for (int i = 0; i < arrSize; i++)
            {
                for (int j = i + 1; j < arrSize; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                FindNumber.PrintOneDArrayInOneLine("On" + i.ToString() + "iteration the array is : ", arr);
            }
            return arr;
        }
        #endregion

        #region Bubble Sort in optimal Way
        /// <summary>
        /// Removed the swap variable to have normal Bubble sort
        /// </summary>
        internal static void MainforBubbleSort()
        {
            int _arrSize = FindNumber.getArrSize();
            int[] arr = new int[_arrSize];
            arr = FindNumber.getArray(_arrSize);

            arr = BubbleSort(arr);

            FindNumber.PrintOneDArrayInOneLine("Finally the sorted array is: ", arr);
        }

        private static int[] BubbleSort(int[] arr)
        {
            int arrSize = arr.Length;
            bool swapped;
            for (int i = 0; i < arrSize - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < arrSize - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                    if (swapped == false)
                    {
                        break;
                    }
                }
                FindNumber.PrintOneDArrayInOneLine("On" + i.ToString() + "iteration the array is : ", arr);
            }
            return arr;
        }
        #endregion

        #region Insertion Sort
        internal class InsertionSort
        {
            public void insertionSort(int[] arr)
            {
                int arrSize = arr.Length;
                for(int i = 1; i < arrSize; i++)
                {
                    int Key = arr[i];
                    int j = i - 1;

                    while(j >= 0 && arr[j] > Key)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = Key;
                }
            }
        }

        internal static void MainforInsertionSort()
        {
            int _arrSize = FindNumber.getArrSize();
            int[] arr = new int[_arrSize];
            arr = FindNumber.getArray(_arrSize);
            InsertionSort ob = new InsertionSort();

            FindNumber.PrintOneDArrayInOneLine("Array Entered is: ", arr);

            ob.insertionSort(arr);

            FindNumber.PrintOneDArrayInOneLine("Finally the Insertion-Sort sorted array is: ", arr);
        }
        #endregion

        #region Merge Sort
        protected internal class MergeSort
        {
            public void mergeSort(int[] arr, int l, int r)
            {
                if (l < r)
                {
                    int m = (l + r) / 2;

                    mergeSort(arr, l, m);
                    mergeSort(arr, m + 1, r);

                    merge(arr, l, m, r);
                }
            }

            public void merge(int[] arr, int l, int m, int r)
            {
                int i, j, k;
                int n1 = m - l + 1;
                int n2 = r - m;

                /* Create temp arrays */
                int[] L = new int[n1];
                int[] R = new int[n2];

                for (i = 0; i < n1; i++)
                {
                    L[i] = arr[l + i];
                }
                for (j = 0; j < n2; j++)
                {
                    R[j] = arr[m + 1 + j];
                }

                i = j = 0;
                k = l;

                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                while (i < n1)
                {
                    arr[k] = L[i];
                    i++; k++;
                }

                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }
        }

        internal static void MainforMergeSort()
        {
            int _arrSize = FindNumber.getArrSize();
            int[] arr = new int[_arrSize];
            arr = FindNumber.getArray(_arrSize);
            MergeSort ob = new MergeSort();

            FindNumber.PrintOneDArrayInOneLine("Array Entered is: ", arr);

            ob.mergeSort(arr, 0, arr.Length - 1);

            FindNumber.PrintOneDArrayInOneLine("Finally the Merge-Sort sorted array is: ", arr);
        }
        #endregion

        #region Heap Sort
        protected internal class HeapSort
        {
            public void heapSort(int[] arr)
            {
                int arr_size = arr.Length;

                //Build the heap
                for (int i = arr_size / 2 - 1; i >= 0; i--)
                {
                    heapify(arr, arr_size, i);
                }

                for (int i = arr_size-1; i >= 0; i--)
                {
                    int temp = arr[0];
                    arr[0] = arr[i];
                    arr[i] = temp;

                    heapify(arr, i, 0);
                }
            }

            public void heapify(int[] arr, int arr_size, int root)
            {
                int largest = root;
                int l = (2 * root) + 1;
                int r = (2 * root) + 2;


                if (l < arr_size && arr[l] > arr[largest])
                {
                    largest = l;
                }

                if (r < arr_size && arr[r] > arr[largest])
                {
                    largest = r;
                }

                if (largest != root)
                {
                    int swap = arr[root];
                    arr[root] = arr[largest];
                    arr[largest] = swap;
                    heapify(arr, arr_size, largest);
                }
            }
        }

        internal static void MainforHeapSort()
        {
            int _arrSize = FindNumber.getArrSize();
            int[] arr = new int[_arrSize];
            arr = FindNumber.getArray(_arrSize);
            HeapSort ob = new HeapSort();

            FindNumber.PrintOneDArrayInOneLine("Array Entered is: ", arr);

            ob.heapSort(arr);

            FindNumber.PrintOneDArrayInOneLine("Finally the Heap-Sort sorted array is: ", arr);
        }
        #endregion

    }
}
