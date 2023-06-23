using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Alogos
{
    public class Matrix
    {
        public static int[,] ReadMatrix(int i, int j)
        {
            int[,] arr = new int[i, j];

            for (int k = 0; k < i; k++)
            {
                for (int l = 0; l < j; l++)
                {
                    Console.WriteLine("Please Enter the Matrix[{0},{1}]", k, l);
                    arr[k, l] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return arr;
        }

        internal static void PrintMatrixInSpiralForm()
        {
            Console.WriteLine("Please Enter the number of rows in the matrix");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the number of columns in the matrix");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter a  3 by 3 matrix");

            int[,] arr = new int[m, n];

            arr = ReadMatrix(m, n);

            int k = 0, l = 0, i;
            //K is the starting row index
            //l is the starting column index
            //m is the ending row index
            //n is the ending column index
            //i is the iterator

            while (k < m && l < n)
            {
                //traversing right
                for(i = l; i < n; i++)
                {
                    Console.Write(arr[k, i] + ", ");
                }
                k++;

                //traversing down
                for (i = k; i < m; i++)
                {
                    Console.Write(arr[i, n-1] + ", ");
                }
                n--;

                //traversing left
                for (i =n; i > l; i--)
                {
                    Console.Write(arr[n, i-1] + ", ");
                }
                m--;

                //traversing up
                for (i = m; i > k; i--)
                {
                    Console.Write(arr[i-1, l] + ", ");
                }
                l++;
            }
            //Console.ReadKey();

        }

        internal static void diagonalDifference()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifferenceCal(arr);

            Console.Write("The difference is : " + result);
        }

        class Result
        {
            public static int diagonalDifferenceCal(List<List<int>> arr)
            {
                int l2r = 0, r2l = 0, n = arr.Count;

                for (int i = 0; i < n; i++)
                {
                    l2r += arr[i][i];
                    r2l = r2l + arr[i][n - i - 1];
                }
                return Math.Abs(l2r - r2l);
            }

        }
    }
}
