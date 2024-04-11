using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsGeeksForGeeks
{
    internal class DSMethods
    {
        //Anagram
        public bool IsAnagram(string r, string s)
        {

            //char ascii = 'a';
            //int value = (int)ascii;

            int len = r.Length > s.Length ? s.Length : r.Length;
            int sum1 = 0, sum2 = 0;

            for (int i = 0; i < len; i++)
            {
                sum1 = sum1 + (int)r[i];
                sum2 = sum2 + (int)s[i];
            }

            if (sum1 == sum2 && r.Length == s.Length)
            {
                Console.WriteLine(true);

            }
            else
            {
                Console.WriteLine(false);
            }
            return true;
        }

        //DuplicateIntegers
        public void CheckIntArrayDupl()
        {
            int[] num = { 1, 1, 2, 5, 2, 3, 2 };
            //int temp;
            //for (int i=0;i<num.Length-1;i++)
            //{
            //    for(int j = 0; j < num.Length - 1; j++)
            //    {
            //        if (num[j] > num[j + 1])
            //        {
            //            temp = num[j];
            //            num[j] = num[j + 1];
            //            num[j + 1] = temp;
            //        }
            //    }
            //}

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            int counter;
            foreach (var pair in num)
            {
                if (!keyValuePairs.Keys.Contains(pair))
                {
                    keyValuePairs.Add(pair, 1);
                }
                else
                {
                    counter = keyValuePairs[pair];
                    counter = counter + 1;
                    keyValuePairs[pair] = counter;
                    Console.WriteLine(pair + " " + keyValuePairs[pair]);
                    return;
                }
            }
            Console.ReadLine();
            return;
            //foreach(var k in keyValuePairs)
            //{
            //    Console.WriteLine(k.Key+" "+k.Value);
            //}


            //var check=num.GroupBy(x=>x);

            //foreach( var check2 in check)
            //{
            //    if(check2.Count() > 1)
            //    {
            //        Console.WriteLine(true);
            //    }
            //}
            //Console.WriteLine(false);

        }


        // Sum of two numbers  = to target

        public int SumOfTwoNums()
        {

            int target = 6;

            int[] arr = { 3,3 };
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (keyValuePairs.ContainsKey(target - arr[i]))
                {
                    Console.WriteLine(keyValuePairs[target - arr[i]] + " " + i);
                    return 0;
                }
                keyValuePairs.Add(arr[i], i);
            }

            return 0;

        }

        public void LongestCOnsecutiveNumbers()
        {
            int[] arr = { 100, 1, 80, 3, 2, 4, 19, 89,96,95,91,93,94,92,90 };

            var sortArr=arr.OrderBy(x=>x);
            //[1,2,3,4,19,80,100]

            int currLongSeq,nextLongSeq=1,j;
            
            for(int i = 0; i < sortArr.Count(); i++)
            {
                currLongSeq = 1;
                
                j = i+1;

                while (j < sortArr.Count())
                {
                    if (sortArr.ElementAt(j) - sortArr.ElementAt(j-1) == 1)
                    {
                        currLongSeq++;
                    }
                    else
                    {
                        if (nextLongSeq < currLongSeq)
                        {
                            nextLongSeq = currLongSeq;
                        }
                        i=j; break;
                    }
                    j=j+1;
                }

                
            }
            Console.WriteLine("Longest Sequence: "+nextLongSeq);
        }

        public void KLongestDuplicates()
        {
            int[] arr = { 1, 1, 1, 2, 2, 3 };
            Dictionary<int,int>  dictInt= new Dictionary<int, int>();
            
            //var sortArr = arr.OrderBy(x => x);
            //string[] words = { "Car", "Car", "Car", "Bird", "Sky", "Sky" };
            //var output = words
            //    .GroupBy(word => word)
            //    .OrderByDescending(group => group.Count()).Select(k=>k.Key);
                
            for(int i=0; i < arr.Count();i++)
            {
                int count = 1;
                if (!dictInt.ContainsKey(arr[i]))
                {
                    dictInt.Add(arr[i],count);
                }
                else
                {
                    dictInt[arr[i]]++;

                }
            }

            foreach(KeyValuePair<int,int> elem in dictInt)
            {
                Console.WriteLine(elem.Key+": "+elem.Value);
            }

        }

        public void ListOfAnagrams()
        {
            //Ввод: strs = ["eat", "tea", "tan", "ate", "nat", "bat"] \
            //Вывод: [["eat","tea","ate"],["tan","nat"],["bat"]]

            string[] arr = { "eat", "tea", "tan", "ate", "nat", "bat" };
            
            int j = 0;
            int[] arrSum = new int[arr.Length];
            foreach(string str in arr)
            {
                int sum = 0;
                for(int i=0; i < str.Length ; i++)
                {
                    sum = sum + (int)str[i];
                }
                arrSum[j] = sum;
                Console.WriteLine(arrSum[j]);
                j++;
                
            }
    }

        public void LongestSubstring()
        {
            string s = "pwwkew";
            string longSub, currLongestSubString="";
            int currLongSubstCount = 1;
            for (int i = 0; i < s.Length-1; i++)
            {
                int counter = 1;

                longSub = s[i].ToString();
                while (s[i] != s[i + 1])
                {
                    if (!longSub.Contains(s[i+1]))
                    {
                        longSub=longSub + s[i+1];
                        counter++;
                        i = i + 1;
                    }
                    else
                    {
                        i = i + 1;
                        break;
                    }
                    
                    
                }
                if (counter > currLongSubstCount)
                {
                    currLongSubstCount = counter;
                    currLongestSubString = longSub;
                }

            }
            Console.WriteLine("Longest Substring Without Duplicates:" + currLongestSubString);
        }

        public void LongestPalindromicSubstring()
        {
            string s = "babac",reverseWord,subWord;
            string currPalSubs = s[0].ToString();

            for (int i = 0;i < s.Length - 1; i++)
            {
                for(int j = i;j<s.Length-1; j++)
                {
                    reverseWord = "";
                    subWord = s.Substring(i, j-i);
                    for (int l = subWord.Length - 1; l >= 0; l--)
                    {
                        reverseWord += subWord[l];
                    }
                    if (subWord == reverseWord)
                    {
                        if (currPalSubs.Length < subWord.Length)
                        {
                            currPalSubs = s.Substring(i, j);
                        }
                    }
                }
            }

            Console.WriteLine("Longest Palindrom Substring: {0}", currPalSubs);
        }

        public void ReverseInteger()
        {
            int actualInt = 120120;
            string reverseInt="";

            for(int i = actualInt.ToString().Length - 1; i >=0 ; i--)
            {
                reverseInt += actualInt.ToString()[i];
            }
            Console.WriteLine(Int32.Parse(reverseInt));
        }

        public void ATOI()
        {
            string s = "-401";
            int strToInt=0;
            for(int i = 0;i<s.Length ; i++)
            {
                //if (s[i] ==)
            }
        }

        public void TwoSum()
        {
            int[] arr = { 4,-1, 0, 1, 2, -1, -4 };
            List<int> list = new List<int>();

            for(int i = 0; i < arr.Length-1; i++)
            {
                List<int> twoSumArr = new List<int> { arr[i] };
                for (int j = i+1; j < arr.Length; j++)
                {
                    int twoSum = -(arr[i] + arr[j]);
                    if (twoSumArr.Contains(twoSum))
                    {
                        //print
                        Console.WriteLine(arr[i] +" "+ arr[j] +" "+ twoSum);

                    }
                    else
                    {
                        twoSumArr.Add(arr[j]);
                    }
                }
            }
        }

        public void SumOfThree()
        {
            int[] arr = { -1, 0, 1, 2, -1, -4 };

            Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();


        }

        public void PhoneLetterCombinations()
        {
            var dictionary = new Dictionary<char, string[]>()
            {
                { '2', new string[]{"a", "b", "c" }},
                { '3', new string[]{"d", "e", "f" }},
                { '4', new string[]{"g", "h", "i" }},
                { '5', new string[]{"j", "k", "l" }},
                { '6', new string[]{"m", "n", "o" }},
                { '7', new string[]{"p", "q", "r", "s" }},
                { '8', new string[]{"t", "u", "v" }},
                { '9', new string[]{"w", "x", "y", "z" }}
            };



        }

        public void LargestPrimeFactor()
        {
            long n = 159;
            long k = 2;
            while (k * k <= n)
            {
                if (n % k == 0)
                {
                    n /= k;
                }
                else
                {
                    ++k;
                }
                }

            Console.WriteLine("Largest Prime Factor: " + n);
        }























    }

}