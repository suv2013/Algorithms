using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Alogos
{
    public class FindWordFromParagraph
    {
        internal static void FindWord()
        {
            Console.WriteLine("Please Enter the Paragraph.");
            string para = Console.ReadLine();
            Console.WriteLine("Please Enter the word.");
            string word = Console.ReadLine();
            int lenOfPara = para.Length;
            int lenOfWord = word.Length;

            int f = 0;

            for (int i = 0; i < lenOfPara; i++)
            {
                if (para[i] == word[0])
                {
                    f++;
                    for (int k = i + 1, j = 1; j < lenOfWord; k++, j++)
                    {
                        if (para[k] == word[j])
                        {
                            f++;
                        }
                    }
                }

            }

            int result = f / lenOfWord;

            if (result > 0)
            {
                Console.WriteLine("Word Present. With " + result + " Occurence.");
            }
            else
            {
                Console.WriteLine("Word Not Present.");
            }

            Console.ReadKey();

        }

        internal static void PalindromeString()
        {
            Console.WriteLine("Please Enter the Word.");
            string word = Console.ReadLine();

            string rev = "", tempWord = word;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                rev += word[i];
            }
            if (rev == word)
            {
                Console.WriteLine("Palindrome String.");
            }
            else
            {
                Console.WriteLine("Not Palindrome String.");
            }
        }

        internal static void MultiplePalindromeString()
        {
            Console.WriteLine("Please Enter the Word.");
            string word = Console.ReadLine();

            string rev = "", tempWord = word;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                rev += word[i];
            }



            if (rev == word)
            {
                Console.WriteLine("Palindrome String.");
            }
            else
            {
                Console.WriteLine("Not Palindrome String.");
            }
        }

        internal static void RemoveDuplicateCharacter()
        {
            Console.WriteLine("Please Enter the Word.");
            string value = Console.ReadLine();
            string result = "";

            foreach (char val in value)
            {
                if (result.IndexOf(val) == -1)
                {
                    result += val;
                }
            }
            Console.WriteLine(result);
        }

        internal static void PrintDuplicateCharacter()
        {
            Console.WriteLine("Please Enter the Word.");
            string value = Console.ReadLine();
            string resultwithoutDuplicate = "";
            string duplicateLetters = "";
            //value = value.Substring(0, value.Length);

            foreach (char val in value)
            {
                if (resultwithoutDuplicate.IndexOf(val) == -1)
                {
                    resultwithoutDuplicate += val;
                }
                else
                {
                    duplicateLetters += val;
                }
            }
            Console.WriteLine(duplicateLetters);
        }

        internal static void IsAnagramWord()
        {
            Console.WriteLine("Please Enter the 1st Word.");
            string word1 = Console.ReadLine().ToLower();
            Console.WriteLine("Please Enter the 2nd Word.");
            string word2 = Console.ReadLine().ToLower();

            char[] wordArr1 = word1.ToCharArray();
            char[] wordArr2 = word2.ToCharArray();

            Array.Sort(wordArr1);
            Array.Sort(wordArr2);

            word1 = new string(wordArr1);
            word2 = new string(wordArr2);

            if (word1 == word2)
            {
                Console.WriteLine("The words are anagram words.");
            }
            else
            {
                Console.WriteLine("The words are not anagram words.");
            }
        }

        public static void MostOccurringCharInString()
        {
            Console.WriteLine("Please Enter the Word.");
            string charString = Console.ReadLine();
            int mostOccurrence = -1;
            char mostOccurringChar = ' ';
            foreach (char currentChar in charString)
            {
                int foundCharOccreence = 0;
                foreach (char charToBeMatch in charString)
                {
                    if (currentChar == charToBeMatch)
                        foundCharOccreence++;
                }
                if (mostOccurrence < foundCharOccreence)
                {
                    mostOccurrence = foundCharOccreence;
                    mostOccurringChar = currentChar;
                }
            }
            Console.WriteLine("Most Occurring Char In String is : " + mostOccurringChar);
        }

        internal static void PrintStairCase()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int space = n - i;
                while (space > 0)
                {
                    Console.Write(" ");
                    space--;
                }
                int hash = i;
                while (hash > 0)
                {
                    Console.Write("#");
                    hash--;
                }
                Console.Write("\n");
            }
        }

        internal static void LargestNonRepeateSubString()
        {
            Console.WriteLine("Please Enter the Word.");
            string s = Console.ReadLine();

            int a_Pointer = 0, b_Pointer = 0, max = 0;

            HashSet<String> myHash = new HashSet<String>();

            while (b_Pointer < s.Length)
            {
                if (!myHash.Contains(s[b_Pointer].ToString()))
                {
                    myHash.Add(s[b_Pointer].ToString());
                    max = Math.Max(myHash.Count, max);
                    b_Pointer++;
                }
                else
                {
                    myHash.Remove(s[a_Pointer].ToString());
                    a_Pointer++;
                }
            }
            Console.WriteLine("The Largest Non Repeated SubString length is " + max + ".");
        }

        internal static void RemoveDuplicateWordsInParagraph()
        {
            Console.WriteLine("Please Enter the Paragraph.");
            string s = Console.ReadLine();
            string[] strArr = s.Split(new string[] { " ", ",", ".", ";", "!", "-", "\'", "\"", "\n", "\\", "/" },
                                StringSplitOptions.RemoveEmptyEntries)
                                .Select(str => str.ToLower())
                                .ToArray();
            //Array.Sort(strArr);

            SortedSet<string> result = new SortedSet<string>();

            for (int i = 0; i < strArr.Length; i++)
            {
                if (i > 0)
                {
                    if (!result.Contains(strArr[i]))
                    {
                        result.Add(strArr[i]);
                    }
                }
                else
                {
                    result.Add(strArr[i]);
                }
            }
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }

        internal static void RemoveDuplicate(string str)
        {

            int n = str.Length;

            HashSet<string> myHash = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                    myHash.Add(str[i].ToString());

                else
                {
                    if (!myHash.Contains(str[i].ToString()))
                        myHash.Add(str[i].ToString());
                }
            }

            Console.WriteLine(string.Join("", myHash));
        }
    }
}
