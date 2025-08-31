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
        public void CountVowelsAndConsonants(string str, ref int V_count, ref int C_count)
        {
            V_count = 0;
            C_count = 0;
            char[] arr = str.ToCharArray();

            HashSet<char> vowels = new HashSet<char>(){ 'a', 'e', 'i', 'o', 'u'};

            foreach (var ch in arr)
            {
                if (!Char.IsLetter(ch))
                    continue;

                if (vowels.Contains(Char.ToLower(ch)))
                {
                    V_count++;
                }
                else
                {
                    C_count++;
                }
            }

        }

        public char? FirstNonRepeatChar(string str)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (var ch in str)
            {
                if (freq.ContainsKey(ch))
                {
                    freq[ch]++;
                }
                else
                {
                    freq[ch] = 1;
                }
            }

            foreach (var ch in str)
            {
                if (freq[ch] == 1)
                    return ch;
            }
            return null;

        }
        public string RemoveDuplicateCharFunc(string strToRemoveDup)
        {
            char[] word = strToRemoveDup.ToCharArray();
            List<char> res = new List<char>();

            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (var ch in word)
            {
                if (freq.ContainsKey(ch))
                {
                    freq[ch]++;
                }
                else
                {
                    freq[ch] = 1;
                }
            }
            foreach (var ch in word)
            {
                if (freq[ch] == 1)
                {
                    res.Add(ch);
                }
            }
            return new String(res.ToArray());

        }
        public string RemoveDuplicateCharFunc1(string str)
        {
            HashSet<char> check = new HashSet<char>();
            List<char> result = new List<char>();

            foreach (char ch in str)
            {
                if (!check.Contains(ch))
                {
                    check.Add(ch);
                    result.Add(ch);
                }
            }
            return new String(result.ToArray());
        }
        public void RemoveDuplicateCharLinqFunc(string strToRemDupLinq)
        {
            Console.WriteLine("Query Syntax");

            var result = (from ch in strToRemDupLinq
                          group ch by ch into g
                          where g.Count() == 1
                          select g.Key).ToArray();

            Console.WriteLine($"{new string(result)}  after removing all occurances");


            Console.WriteLine("Method Syntax");
            var resultMethod = (strToRemDupLinq
                 .GroupBy(c => c)
                 .Where(g => g.Count() == 1)
                                        .Select(g => g.Key)).ToArray();

            Console.WriteLine($"{new string(resultMethod)} after removing all occurance\n");

        }
        public void RemoveDuplicateCharLinqFunc1(string strToRemDupLinq)
        {
            Console.WriteLine("Remove Duplicate by keeping first occurance");
            Console.WriteLine("Query Syntax");

            var KeepFirstOccur = (from ch in strToRemDupLinq
                                  group ch by ch into g
                                  select g.First()).ToArray();

            Console.WriteLine($"{new string(KeepFirstOccur)} After removing duplicate characters by keeping first occurance\n");

            var KeepFirstOccurMethod = strToRemDupLinq
                                        .GroupBy(c => c)
                                        .Select(g => g.First()).ToArray();

            Console.WriteLine($"{new string(KeepFirstOccurMethod)} After removing duplicate characters by keeping first occurance\n");

        }
        public  Dictionary<char, int> CountFrequencyCharFunc(string str)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char ch in str)
            {
                if (freq.ContainsKey(ch))
                {
                    freq[ch]++;
                }
                else
                {
                    freq[ch] = 1;
                }
            }

            return freq;
        }
        public void CountFrequencyCharLinqFunc(string strToCountFreqChar)
        {
            Console.WriteLine("Query Syntax");
            var Freq = from ch in strToCountFreqChar
                       group ch by ch into g
                       select new { Character = g.Key, Count = g.Count() };

            foreach (var item in Freq)
            {
                Console.WriteLine($"{item.Character}:{item.Count}");
            }

            Console.WriteLine("Method Syntax");

            var FreqMethod = strToCountFreqChar
                            .GroupBy(c => c)
                            .Select(g => new { Character = g.Key, Count = g.Count() });

            foreach (var item in FreqMethod)
            {
                Console.WriteLine($"{item.Character}:{item.Count} \n");
            }

        }
        public  string ReverseWordFunc(string str)
        {
            string[] words = str.Split(' ');
            int right = words.Length - 1, left = 0;

            while (left < right)
            {
                string temp = words[left];
                words[left] = words[right];
                words[right] = temp;
                left++;
                right--;
            }

            return string.Join(" ", words);
        }

        public bool CheckAnagrams(string first,string second)
        {
            char[] FirstArr = first.ToLower().ToCharArray();
            Array.Sort(FirstArr);
            string FirstAfterSorting = new string(FirstArr);

            char[] SecondArr = second.ToLower().ToCharArray();
            Array.Sort(SecondArr);
            string SecondAfterSorting = new string(SecondArr);

            if (FirstAfterSorting == SecondAfterSorting) return true;
            else return false;
           
        }

        public void FindSubstringFunc(string str)
        {
            Console.WriteLine("Substrings are");
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    Console.WriteLine(str.Substring(i, j - i + 1));
                }
            }

        }
        public  string LongestWordFunc(string str)
        {
            string[] words = str.Split(' ');
            string longestword = "";
            foreach (var word in words)
            {
                if (word.Length > longestword.Length)
                {
                    longestword = word;
                }
            }
            return longestword;
        }

        public void FirstNonRepeatCharLinqFunc(string word)
        {
            Console.WriteLine("Query Syntax");

            var result = (from c in word
                          group c by c into g
                          where g.Count() == 1
                          select g.Key).FirstOrDefault();
            if (result != default(char))
                Console.WriteLine($"{result} is first non repeated character\n");

            Console.WriteLine("Method Syntax");

            var result1 = word.GroupBy(c => c)
                       .Where(g => g.Count() == 1)
                       .Select(g=>g.Key).FirstOrDefault();
            if (result1 != default(char))
                Console.WriteLine($"{result1} is first non repeated  character\n");

        }

    }
}
