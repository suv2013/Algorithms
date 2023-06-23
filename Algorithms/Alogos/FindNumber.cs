using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Algorithms.Alogos
{
    public class FindNumber
    {
        public static int getArrSize()
        {
            Console.WriteLine("Please Enter the size of the array");
            int _arrSize = Convert.ToInt32(Console.ReadLine());
            return _arrSize;
        }

        public static int[] getArray(int _arrSize)
        {
            Console.WriteLine("Please Enter the array of size {0}", _arrSize.ToString());
            int[] arr = new int[_arrSize];
            for (int l = 0; l < arr.Length; l++)
            {
                Console.WriteLine("Please Enter the {0}th element of the array", l);
                arr[l] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        public static int[] getArray(int _arrSize, string textToShow)
        {
            Console.WriteLine("{0} {1}", textToShow, _arrSize.ToString());
            int[] arr = new int[_arrSize];
            for (int l = 0; l < arr.Length; l++)
            {
                Console.WriteLine("Please Enter the {0}th element of the array", l);
                arr[l] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        public static int elementToFind()
        {
            Console.WriteLine("Please Enter the element to find");
            int _elementToFind = Convert.ToInt32(Console.ReadLine());
            return _elementToFind;
        }

        internal static void FindTheElement()
        {
            int _arrSize = getArrSize();
            int[] arr = new int[_arrSize];
            arr = getArray(_arrSize);
            int _elementToFind = elementToFind();
            string res = "";
             
            for(int i = 0; i< _arrSize; i++)
            {
                if(arr[i] == _elementToFind)
                {
                    res = "Element Found";
                    Console.WriteLine(res);
                    break;
                }
            }
            if(res == "") Console.WriteLine("Element not Found");

            Console.ReadKey();
        }

        private static int getElement(string mesg)
        {
            Console.WriteLine(mesg);
            int _element = Convert.ToInt32(Console.ReadLine());
            return _element;
        }

        public static void PrintOneDArray(string mesg, int[] arr)
        {
            Console.WriteLine(mesg);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
                        
            Console.ReadKey();
        }

        public static void PrintOneDArrayInOneLine(string mesg, int[] arr)
        {
            Console.WriteLine(mesg);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString());
                if ((i + 1) < arr.Length)
                {
                    Console.Write(",");
                }
            }

            Console.ReadKey();
        }

        private static void PrintList(string mesg, List<int> lstObj)
        {
            Console.WriteLine(mesg);

            for (int i = 0; i < lstObj.Count; i++)
            {
                if (i == 0)
                    Console.Write("{0}",lstObj[i].ToString());
                else
                    Console.Write(", {0}", lstObj[i].ToString());

            }

            Console.Write(".");

            Console.ReadKey();
        }

        internal static void FindTheOddNumbers()
        {
            int sPoint = getElement("Enter the starting Range.");
            int ePoint = getElement("Enter the ending Range.");

            List<int> oddNumbers = new List<int>();

            

            for (int i = 0; sPoint < ePoint; i++, sPoint++)
            {
                if (sPoint % 2 > 0)
                {
                    oddNumbers.Add(sPoint);
                }
            }

            PrintList("The odd numbers are : ", oddNumbers);
            
        }

        internal static void FindTheEvenNumbers()
        {
            int sPoint = getElement("Enter the starting Range.");
            int ePoint = getElement("Enter the ending Range.");

            List<int> evenNumbers = new List<int>();



            for (int i = 0; sPoint < ePoint; i++, sPoint++)
            {
                if (sPoint % 2 == 0)
                {
                    evenNumbers.Add(sPoint);
                }
            }

            PrintList("The Even numbers are : ", evenNumbers);

        }

        internal static void FindThePrimeNumbers()
        {
            int sPoint = getElement("Enter the starting Range.");
            int ePoint = getElement("Enter the ending Range.");

            List<int> primeNumbers = new List<int>();

            for (; sPoint < ePoint; sPoint++)
            {
                int ctr = 0;
                for (int i = 2; i < sPoint / 2; i++) {
                    if (sPoint % i == 0)
                    {
                        ctr++;
                        break;
                    }                    
                }
                if(ctr == 0 && sPoint != 1)
                {
                    primeNumbers.Add(sPoint);
                }
            }

            PrintList("The Even numbers are : ", primeNumbers);

        }

        internal static void PrintFibonacciNumbers()
        {
            int ePoint = getElement("Enter the ending Range for Fibonacci Series.");
            List<int> fibonacciNumbers = new List<int>();
            fibonacciNumbers.Add(0);
            fibonacciNumbers.Add(1);

            for (int sPoint = 1, val = 0 ; val < ePoint; sPoint++)
            {
                val = fibonacciNumbers[sPoint] + fibonacciNumbers[sPoint - 1];
                if(val < ePoint)
                fibonacciNumbers.Add(val);                
            }

            PrintList("The Even numbers are : ", fibonacciNumbers);
        }

        internal static void PalindromeNumbers()
        {
            int palidromeNum = getElement("Enter the number you consider as palindrome.");
            int tempNum = palidromeNum;
            int r, sum = 0;
            while (palidromeNum > 0)
            {
                r = palidromeNum % 10;
                sum = (sum * 10) + r;
                palidromeNum = palidromeNum / 10;
            }
            if (tempNum == sum)
                Console.WriteLine("The number is palindrome.");
            else
                Console.WriteLine("The number is not palindrome.");

            Console.ReadKey();
        }

        internal static void ReverseAnumber()
        {
            int numToReverse = getElement("Enter the number you want to reverse.");
            int tempNum = numToReverse;
            int r, reversedNumber = 0;
            while (numToReverse > 0)
            {
                r = numToReverse % 10;
                reversedNumber = (reversedNumber * 10) + r;
                numToReverse = numToReverse / 10;
            }
            Console.WriteLine("The reverse number is : {0}", reversedNumber);

            Console.ReadKey();
        }

        internal static void FactorialOfANumber()
        {
            int fNum = getElement("Enter the number you want Factorial of.");
            int tempFNum = fNum;
            int res = fNum;
            while (fNum > 0)
            {
                if (--fNum > 0)
                    res = res * fNum;
            }

            Console.WriteLine("The factorial of the number {0} is {1} .", tempFNum, res);

            Console.ReadKey();
        }


        //Armstrong number is a number that is equal to the sum of cubes of its digits.For example 0, 1, 153, 370, 371 and 407 are the Armstrong numbers.

        //Let's try to understand why 153 is an Armstrong number.

        //153 = (1*1*1)+(5*5*5)+(3*3*3)  
        //where:  
        //(1*1*1)=1  
        //(5*5*5)=125  
        //(3*3*3)=27  
        //So:  
        //1+125+27=153
        internal static void ArmstrongNumber_old()
        {
            int num = getElement("Enter the number you want Armstrong number of.");
            int temp = num;
            int armstrongNum = num;
            int r, i = 0;
            int sum = 0;
            while (temp > 0)
            {
                temp = temp / 10;
                i++;
            }
            temp = i;
            while (temp > 0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + (int)Math.Pow(r, i);
                temp--;
            }

            if (armstrongNum == sum)
                Console.WriteLine("The number is Armstrong Number.");
            else
                Console.WriteLine("The number is not Armstrong Number.");

            Console.ReadKey();
        }

        internal static void ArmstrongNumber()
        {
            int num = getElement("Enter the number you want Armstrong number of.");
            int temp = num;
            int armstrongNum = num;
            int sum = 0;
            int numberofdigit = Convert.ToString(num).Length;
            for(int i=0; i < numberofdigit; i++)
            {
                temp = num % 10;
                sum = sum + (int)Math.Pow(temp, 3);
                num = num / 10;
            }           

            if (armstrongNum == sum)
                Console.WriteLine("The number is Armstrong Number.");
            else
                Console.WriteLine("The number is not Armstrong Number.");

            Console.ReadKey();
        }

        internal static void SumOfDigits()
        {
            int num = getElement("Enter the number you want to get the sum of.");
            int tempNum = num;
            int r, sum = 0;
            while (num > 0)
            {
                r = num % 10;
                sum = sum + r;
                num = num / 10;
            }
            
            Console.WriteLine("The sum of the number {0} is {1}", tempNum, sum);

            Console.ReadKey();
        }

        internal static void SwapNumber()
        {
            int num1 = getElement("Please Enter the value of 1st Number.");
            int num2 = getElement("Please Enter the value of 2nd Number.");

            int x = num1; //20
            int y = num2; //30

            x = x + y; //50
            y = x - y; //20
            x = x - y; //30

            Console.WriteLine("The value of the number now num1 is {0} and num2 is {1}.", x, y);

            Console.ReadKey();
        }

        internal static void DecimalToBinary()
        {
            int deciNum = getElement("Enter the number to convert to binary.");
            int tempNum = deciNum;
            int r;

            List<int> binaryArr = new List<int>();

            while (deciNum > 0)
            {
                r = deciNum % 2;
                binaryArr.Add(r);
                deciNum = deciNum / 2;
            }

            Console.Write("The binary number of number {0} is : " , tempNum);
            for (int i = binaryArr.Count-1; i >= 0; i--)
            {
                Console.Write("{0}", binaryArr[i].ToString());
            }
            Console.Write(".");

            Console.ReadKey();
        }

        internal static void KDifference()
        {
            int arrSize = getArrSize();
            int[] arr = new int[arrSize];
            arr = getArray(arrSize);

            int k = getElement("Please enter the size you want distinct of.");
            int count = 0;
            for(int i = 0; i < arrSize; i++)
            {
                for(int j = i + 1; j < arrSize; j++)
                {
                    if (arr[i] - arr[j] == k || arr[j] - arr[i] == k)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("The number of the distinct pairs are : {0}", count);

            Console.ReadKey();
        }

        internal static void InvertActualBitsOfANumber()
        {
            int deciNum = getElement("Please Enter the number :");
            int tempNum = deciNum;
            int r;

            List<int> binaryArr = new List<int>();

            while (tempNum > 0)
            {
                r = tempNum % 2;
                binaryArr.Add(r);
                tempNum = tempNum / 2;
            }
            r = 0;

            List<int> binaryInvertedArr = new List<int>();

            foreach (int ba in binaryArr)
            {
                if (!(ba == 0 && r == 0))
                {
                    binaryInvertedArr.Add(ba);
                }
                r++;
            }

            Console.Write("The inverted array is : ");

            for (r = 0; r < binaryInvertedArr.Count; r++)
            {
                Console.Write(Convert.ToString(binaryInvertedArr[r]));
            }
            tempNum = 0;
            for (r = 0; r < binaryInvertedArr.Count; r++)
            {
                if (binaryInvertedArr[r] == 1)
                {
                    if (r == 0)
                    {
                        tempNum += 1;
                    }
                    else
                    {
                        tempNum += (int)Math.Pow(2, r);
                    }
                }
            }

            Console.WriteLine("\nThe inverted number is : {0}", tempNum);

            Console.ReadKey();
        }

        static void plusMinus(int[] arr)
        {

            int posi = 0, nega = 0, equ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    posi++;
                    continue;
                }
                if (arr[i] > 0)
                {
                    nega++;
                    continue;
                }
                if (arr[i] == 0)
                {
                    equ++;
                    continue;
                }
            }

            decimal fposi = decimal.Divide(posi ,arr.Length);
            decimal fnega = decimal.Divide(nega , arr.Length);
            decimal fequ = decimal.Divide(equ , arr.Length);

            Console.WriteLine(Convert.ToString(fposi));
            Console.WriteLine(Convert.ToString(fnega));
            Console.WriteLine(Convert.ToString(fequ));

        }

        internal static void plusMinusMain()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }

        internal static void miniMaxSum()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int max = 0, min = 0, n = arr.Length - 1;
            for (int i = 0; i < n; i++)
            {
                max += arr[n - i];
                min += arr[i];
            }
            Console.WriteLine(min + " " + max);
        }

        internal static void arrayLeftRotation()
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));

        }

        private static int[] rotLeft(int[] arr, int d)
        {
            int lengthOfArray = arr.Length, shiftAmount = d;
            int[] new_arr = new int[lengthOfArray];

            for (int i = 0; i <= d; i++)
            {
                int newLocation = (i + shiftAmount) % lengthOfArray;
                new_arr[i] = arr[newLocation];

                //int tempI = arr[0];

                //for (int j = 1; j < arr.Length; j++)
                //{
                //    arr[j-1] = arr[j];
                //}
                //arr[arr.Length - 1] = tempI;
            }
            return new_arr;
        }

        protected internal static void LargestSumOfContinousArray()
        {
            int arrSize = getArrSize();
            int[] arr = new int[arrSize];

            arr = getArray(arrSize);

            int[] resultArr = new int[arr.Length];
            resultArr[0] = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                int tempCount = resultArr[i - 1] + arr[i];
                if (tempCount > resultArr[i - 1])
                {
                    resultArr[i] = tempCount;
                }
                else
                {
                    resultArr[i] = resultArr[i - 1];
                    resultArr[i - 1] = tempCount;
                }
            }
            Console.WriteLine(resultArr[resultArr.Length-1].ToString());

            int max_so_far = int.MinValue,
                max_ending_here = 0;

            for (int i = 0; i < arrSize; i++)
            {
                max_ending_here = max_ending_here + arr[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            //return max_so_far;

            Console.WriteLine(max_so_far.ToString());
        }

        //O(log n)
        internal static void FindSuarRoot()
        {
            int t = elementToFind();
            int start = 0, end = t, ans = 0;

            while(start <= end)
            {
                int mid = (start + end + 1) / 2;

                if(mid * mid == t)
                {
                    Console.WriteLine(mid.ToString());
                }
                if(mid*mid < t)
                {
                    start = mid + 1;
                    ans = mid;

                }
                else
                {
                    end = mid - 1;
                }
            }

            Console.WriteLine(ans.ToString());
        }

        internal static void RemoveDuplicateFromSortedArray()
        {
            Console.WriteLine("Please enter a Sorted Array");
            int[] arr = Console.ReadLine().Split(',').Select(num => int.Parse(num)).ToArray();

            int i = 0;

            for(int j = 1; j < arr.Length; j++)
            {
                if(arr[i] != arr[j])
                {
                    i++;
                    arr[i] = arr[j];
                }
            }

            for(int j = 0; j < i+1; j++)
            {
                Console.Write(arr[j] + ",");
            }
        }

        internal static void MaxSumOFSubArray()
        {
            int _arrSize = getArrSize();
            int[] nums = new int[_arrSize];
            nums = getArray(_arrSize);

            int maxSoFar = nums[0];
            int currMax = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                currMax = Math.Max(nums[i], currMax + nums[i]);
                maxSoFar = Math.Max(maxSoFar, currMax);
            }

            Console.WriteLine("MaxSumOFSubArray is : " + maxSoFar );
        }

        internal static void TwoSum()
        {
            int _arrSize = getArrSize();
            int[] nums = new int[_arrSize];
            nums = getArray(_arrSize);

            int target = elementToFind();

            int[] result = new int[2];
            

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];

                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(temp, i);
                }
                else
                {
                    result[0] = map[nums[i]];
                    result[1] = i;

                }
            }

            Console.WriteLine(result[0] +  result[1]);

        }
    }
}
