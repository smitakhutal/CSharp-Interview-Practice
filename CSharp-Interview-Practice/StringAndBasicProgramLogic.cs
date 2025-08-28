using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Interview_Practice
{
    internal class StringAndBasicProgramLogic
    {
        public string ReverseStringFunc(char[] arr)
        {
            char[] res = new char[arr.Length];

            for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++)
            {
                res[j] = arr[i];
            }
            return new string(res);

        }
        public bool PalindromeCheck(string str)
        {

            string originalstring = str;
            char[] str1 = str.ToCharArray();
            int right = str.Length - 1, left = 0;
            while (left < right)
            {
                char temp = str1[left];
                str1[left] = str1[right];
                str1[right] = temp;
                right--;
                left++;
            }
            if (new String(str1) == originalstring) return true;
            else return false;


        }

        public  bool CheckPalindrome(string str)
        {
            int last = str.Length - 1, first = 0;

            while (first < last)
            {
                if (str[first] != str[last])
                    return false;

                first++;
                last--;
            }

            return true;
        }

    }
}
