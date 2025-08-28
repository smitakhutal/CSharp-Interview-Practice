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
            
                Console.WriteLine("Provide input from given list");
                Console.WriteLine("1.Reverse string without built-in Reverse()");
                Console.WriteLine("2.Check palindrome string");
                Console.WriteLine("3.Optimize version of two pointers for palindrome");
                Console.WriteLine("4.Count vowels and consonants");
                Console.WriteLine("5.Find first non-repeated character");
                Console.WriteLine("0.Exit");
            while (ContinueApp)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        ContinueApp=false;
                        break;
                    case 1:
                        Console.WriteLine("Enter String to reverse");
                        string str = Console.ReadLine();

                        char[] arr = str.ToCharArray();

                        string Result = logic.ReverseStringFunc(arr);
                        Console.WriteLine($"{Result} string is reverse of {str}");
                        break;
                    case 2:
                        Console.WriteLine("Enter string to check");
                        string strToCheck = Console.ReadLine();

                        bool result = logic.PalindromeCheck(strToCheck);
                        if (result)
                        {
                            Console.WriteLine($"{strToCheck} is Palindrome");
                        }
                        else
                        {
                            Console.WriteLine($"{strToCheck} is not Palindrome");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Enter stirng to check");
                        string strToCheckPalindrome = Console.ReadLine();

                        bool res = logic.CheckPalindrome(strToCheckPalindrome);
                        if (res)
                        {
                            Console.WriteLine($"{strToCheckPalindrome} is Palindrome");
                        }
                        else
                        {
                            Console.WriteLine($"{strToCheckPalindrome} is not Palindrome");
                        }
                        break;
                    default:
                        Console.WriteLine("You have entered wrong input");
                        break;

                }
            }
            Console.WriteLine("Enter any keyto exit");
            Console.ReadKey();
        }
    
    }
}
