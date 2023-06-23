using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Alogos;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 1 to Find word in the Paragraph.");
            Console.WriteLine("Please Enter 2 to print matrix in spiral form.");
            Console.WriteLine("Please Enter 3 to Find Numbers with Linear Search");
            Console.WriteLine("Please Enter 4 to Find Odd Numbers");
            Console.WriteLine("Please Enter 5 to Find Even Numbers");
            Console.WriteLine("Please Enter 6 to Find Prime Numbers");
            Console.WriteLine("Please Enter 7 to Find Fibonacci Numbers");
            Console.WriteLine("Please Enter 8 to Find Palindrome Number");
            Console.WriteLine("Please Enter 9 to Reverse a Number");
            Console.WriteLine("Please Enter 10 to Find Factorial of a Number");
            Console.WriteLine("Please Enter 11 to Find a number to be Armstrong Number");
            Console.WriteLine("Please Enter 12 to Find a sum of a Number");
            Console.WriteLine("Please Enter 13 to Swap a Number");
            Console.WriteLine("Please Enter 14 to Find binary of a decimal number");
            Console.WriteLine("Please Enter 15 to Find Numbers with Binary Search");
            Console.WriteLine("Please Enter 16 to Find KDistinct of a array");
            Console.WriteLine("Please Enter 17 to Find Invert Actual Bits Of A Number");
            Console.WriteLine("Please Enter 18 to Find Palindrome String ");
            Console.WriteLine("Please Enter 19 to Find Numbers with Jump Search : ");
            Console.WriteLine("Please Enter 20 to Sort with Selection Sort : ");
            Console.WriteLine("Please Enter 21 to Sort with Bubble Sort : ");
            Console.WriteLine("Please Enter 22 to Sort with Insertion Sort : ");
            Console.WriteLine("Please Enter 23 to Sort with Merge Sort : ");
            Console.WriteLine("Please Enter 24 to Sort with Merge Sort : ");
            Console.WriteLine("Please Enter 25 to Remove duplicate character : ");
            Console.WriteLine("Please Enter 26 to Find two words are Anagram : ");
            Console.WriteLine("Please Enter 27 to Print duplicate character : ");
            Console.WriteLine("Please Enter 28 for Most Occurring Char In String : ");
            Console.WriteLine("Please Enter 29 for diagonal Difference of a matrix : ");
            Console.WriteLine("Please Enter 30 for plus Minus and Zero in a array : ");
            Console.WriteLine("Please Enter 31 for Print Stair Case : ");
            Console.WriteLine("Please Enter 32 for Print mini Max Sum : ");
            Console.WriteLine("Please Enter 33 for Array Left Rotation : ");
            Console.WriteLine("Please Enter 34 for Largest Sum Of Continous Array : ");
            Console.WriteLine("Please Enter 35 for Largest Non Repeated SubString : ");
            Console.WriteLine("Please Enter 36 for Fastest FindSuarRoot : ");
            Console.WriteLine("Please Enter 37 for Fastest FindSuarRoot : ");
            Console.WriteLine("Please Enter 38 to Remove Duplicate From SortedArray : ");
            Console.WriteLine("Please Enter 39 to Max Sum OF Sub-Array (Kadane Algo): ");
            Console.WriteLine("Please Enter 40 to Two Sum: ");
            Console.WriteLine("Please Enter 41 to Remove Duplicate from String: ");


            int value = Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                case 1 :
                    FindWordFromParagraph.FindWord();
                    break;

                case 2 :
                    Matrix.PrintMatrixInSpiralForm();
                    break;

                case 3:
                    FindNumber.FindTheElement();
                    break;

                case 4:
                    FindNumber.FindTheOddNumbers();
                    break;

                case 5:
                    FindNumber.FindTheEvenNumbers();
                    break;

                case 6:
                    FindNumber.FindThePrimeNumbers();
                    break;

                case 7:
                    FindNumber.PrintFibonacciNumbers();
                    break;

                case 8:
                    FindNumber.PalindromeNumbers();
                    break;

                case 9:
                    FindNumber.ReverseAnumber();
                    break;

                case 10:
                    FindNumber.FactorialOfANumber();
                    break;

                case 11:
                    FindNumber.ArmstrongNumber();
                    break;

                case 12:
                    FindNumber.SumOfDigits();
                    break;

                case 13:
                    FindNumber.SwapNumber();
                    break;

                case 14:
                    FindNumber.DecimalToBinary();
                    break;

                case 15:
                    SeachingAlgorithm.MainForBinarySearch();
                    break;

                case 16:
                    FindNumber.KDifference();
                    break;

                case 17:
                    FindNumber.InvertActualBitsOfANumber();
                    break;

                case 18:
                    FindWordFromParagraph.PalindromeString();
                    break;

                case 19:
                    SeachingAlgorithm.MainforJumpSearch();
                    break;

                case 20:
                    SortingAlgorithm.MainforSelectionSort();
                    break;

                case 21:
                    SortingAlgorithm.MainforBubbleSort();
                    break;

                case 22:
                    SortingAlgorithm.MainforInsertionSort();
                    break;

                case 23:
                    SortingAlgorithm.MainforMergeSort();
                    break;

                case 24:
                    SortingAlgorithm.MainforHeapSort();
                    break;
                case 25:
                    FindWordFromParagraph.RemoveDuplicateCharacter();
                    break;
                case 26:
                    FindWordFromParagraph.IsAnagramWord();
                    break;
                case 27:
                    FindWordFromParagraph.PrintDuplicateCharacter();
                    break;
                case 28:
                    FindWordFromParagraph.MostOccurringCharInString();
                    break;
                case 29:
                    Matrix.diagonalDifference();
                    break;
                case 30:
                    FindNumber.plusMinusMain();
                    break;
                case 31:
                    FindWordFromParagraph.PrintStairCase();
                    break;
                case 32:
                    FindNumber.miniMaxSum();
                    break;
                case 33:
                    FindNumber.arrayLeftRotation();
                    break;
                case 34:
                    FindNumber.LargestSumOfContinousArray();
                    break;
                case 35:
                    FindWordFromParagraph.LargestNonRepeateSubString();
                    break;
                case 36:
                    FindNumber.FindSuarRoot();
                    break;
                case 37:
                    FindWordFromParagraph.RemoveDuplicateWordsInParagraph();
                    break;
                case 38:
                    FindNumber.RemoveDuplicateFromSortedArray();
                    break;
                case 39:
                    FindNumber.MaxSumOFSubArray();
                    break;
                case 40:
                    FindNumber.TwoSum();
                    break;
                case 41:
                    FindWordFromParagraph.RemoveDuplicate("aabbccdddyyy");
                    break;

                default:
                    Console.WriteLine("Please visit next time.");
                    break;
            }

            Console.ReadKey();

        }
    }
}
