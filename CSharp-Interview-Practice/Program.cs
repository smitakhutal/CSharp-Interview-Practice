using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Interview_Practice
{
    internal class StringAndBasicProgramAccess
    {
        static void Main(string[] args)
        {
            //Variable declaration
            StringAndBasicProgramLogic logic = new StringAndBasicProgramLogic();
            bool ContinueApp = true;
            while (ContinueApp)
            {
                Console.WriteLine("Provide input from given list");
                Console.WriteLine("1.Reverse string without built-in Reverse()");
                Console.WriteLine("2.Check palindrome string");
                Console.WriteLine("3.Optimize version of two pointers for palindrome");
                Console.WriteLine("4.Count vowels and consonants");
                Console.WriteLine("5.Find first non-repeated character");
                Console.WriteLine("6.Find first non-repeated character using Linq");
                Console.WriteLine("7.Remove duplicate characters from a string");
                Console.WriteLine("8.Remove duplicate characters from a string using linq");
                Console.WriteLine("9.Find frequency of characters");
                Console.WriteLine("10.Find frequency of characters using Linq");
                Console.WriteLine("11.Reverse words in a sentence");
                Console.WriteLine("12.Check anagrams");
                Console.WriteLine("13.Print all substrings of a string");
                Console.WriteLine("14.Find longest word in a string");
                Console.WriteLine("0.Exit\n");
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 0:
                            ContinueApp = false;
                            break;
                        case 1:
                            Console.WriteLine("Enter String to reverse");
                            string str = Console.ReadLine();

                            char[] arr = str.ToCharArray();

                            string Result = logic.ReverseStringFunc(arr);
                            Console.WriteLine($"{Result} string is reverse of {str}\n");
                            break;
                        case 2:
                            Console.WriteLine("Enter string to check");
                            string strToCheck = Console.ReadLine();

                            bool result = logic.PalindromeCheck(strToCheck);
                            if (result)
                            {
                                Console.WriteLine($"{strToCheck} is Palindrome \n");
                            }
                            else
                            {
                                Console.WriteLine($"{strToCheck} is not Palindrome\n");
                            }

                            break;
                        case 3:
                            Console.WriteLine("Enter stirng to check");
                            string strToCheckPalindrome = Console.ReadLine();

                            bool res = logic.CheckPalindrome(strToCheckPalindrome);
                            if (res)
                            {
                                Console.WriteLine($"{strToCheckPalindrome} is Palindrome \n");
                            }
                            else
                            {
                                Console.WriteLine($"{strToCheckPalindrome} is not Palindrome \n");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter string to count Vowels and Consonants");
                            string vowelcheckstr = Console.ReadLine();
                            int V_count = 0;
                            int C_count = 0;

                            logic.CountVowelsAndConsonants(vowelcheckstr, ref V_count, ref C_count);

                            Console.WriteLine($"Vowels : {V_count} and Consonants : {C_count} \n");

                            break;
                        case 5:
                            Console.WriteLine("Enter string to check");
                            string strForNonRepChar = Console.ReadLine();

                            char? resultChar = logic.FirstNonRepeatChar(strForNonRepChar);

                            if (resultChar.HasValue)
                            {
                                Console.WriteLine($"{resultChar} is first non-repeated character \n");
                            }
                            else
                            {
                                Console.WriteLine("All the characters are repeated \n");
                            }
                            break;
                        case 6:
                            Console.WriteLine("Enter string to check");
                            string word = Console.ReadLine();
                            logic.FirstNonRepeatCharLinqFunc(word);

                            break;


                        case 7:
                            Console.WriteLine("Enter string to remove duplicate");
                            string strToRemoveDup = Console.ReadLine();

                            Console.WriteLine("Completely remove repeated characters from string");
                            string resultStr = logic.RemoveDuplicateCharFunc(strToRemoveDup);

                            Console.WriteLine($"{resultStr} after removing duplicate characters");

                            Console.WriteLine("Remove character but keep first occurance from string");
                            string resultstr1 = logic.RemoveDuplicateCharFunc1(strToRemoveDup);

                            Console.WriteLine($"{resultstr1} after removing duplicate characters and keeping first occurance \n");

                            break;
                        case 8:
                            Console.WriteLine("Enter String to remove Duplicate");
                            string strToRemDupLinq = Console.ReadLine();

                            logic.RemoveDuplicateCharLinqFunc(strToRemDupLinq);
                            logic.RemoveDuplicateCharLinqFunc1(strToRemDupLinq);
                            break;
                        case 9:
                            Console.WriteLine("Enter String to count frequency of character");
                            string strToCountFreqChar = Console.ReadLine();

                            Dictionary<char, int> resultFreqChar = new Dictionary<char, int>();

                            resultFreqChar = logic.CountFrequencyCharFunc(strToCountFreqChar);

                            foreach (var ch in resultFreqChar)
                            {
                                Console.WriteLine($"{ch.Key} : {ch.Value}");
                            }


                            break;
                        case 10:
                            Console.WriteLine("Enter string to check frequency of character");
                            string strToCountFreqCharlinq = Console.ReadLine();
                            logic.CountFrequencyCharLinqFunc(strToCountFreqCharlinq);

                            break;
                        case 11:
                            Console.WriteLine("Enter string to reverse words");
                            string strToReverseWords = Console.ReadLine();

                            string ResultString = logic.ReverseWordFunc(strToReverseWords);

                            Console.WriteLine($"String after reversing words:{ResultString} \n");
                            break;
                        case 12:
                            Console.WriteLine("Enter first string");
                            string first = Console.ReadLine();

                            Console.WriteLine("Enter Second string");
                            string second = Console.ReadLine();
                            bool resOfAnagram = logic.CheckAnagrams(first, second);
                            if (resOfAnagram)
                            {
                                Console.WriteLine("{0} and  {1} String are anagrams \n", first, second);
                            }
                            else
                            {
                                Console.WriteLine("{0} and  {1} String are not anagrams \n", first, second);
                            }

                            break;
                        case 13:
                            Console.WriteLine("Enter string to find substring");
                            string strToFindSubstr = Console.ReadLine();

                            logic.FindSubstringFunc(strToFindSubstr);

                            break;
                        case 14:
                            Console.WriteLine("Enter string to find longest word");
                            string strToFindLongWord = Console.ReadLine();

                            string Longest = logic.LongestWordFunc(strToFindLongWord);
                            Console.WriteLine(Longest + " is Longest word in string");

                            break;
                        default:
                            Console.WriteLine("You have entered wrong input");
                            break;

                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Enter any keyto exit");
            Console.ReadKey();
        }
    
    }
}
