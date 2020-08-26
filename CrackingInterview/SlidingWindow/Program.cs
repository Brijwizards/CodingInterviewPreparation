using System;
using System.Collections.Generic;

namespace SlidingWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //CheckInclusion("ab", "eidboaoo");
            FindAnagrams("cbaebabacd", "abc");
        }

        /// <summary>
        /// https://leetcode.com/problems/find-all-anagrams-in-a-string/discuss/636988/sliding-window-hashtable-java-explained-with-diagram-beats-99
        /// </summary>       
        /*
         !Time Complexity - O(S)
         Each array element element would be traversed at most twice . First time by windowEnd to decrement the value, then by windowStart to increment . Best case would be when none of the array elements are part of anagram.
         eg - P = 'abc' S = 'xyzr' . Here, both windowEnd and windowStart would be incremented at same time.
         Space complexity - O(1)
         Since we are using constant extra space (map) of size 26
         */
         
        public static List<int> FindAnagrams(string s, string p)
        {
            int[] map = new int[26];
            var result = new List<int>();

            for (int i = 0; i < p.Length; i++)
            {
                map[p[i] - 'a']++;
            }

            int windowStart = 0;
            int windowEnd = 0;
            while (windowEnd < s.Length)
            {
                // valid anagram
                if (map[s[windowEnd] - 'a'] > 0)
                {
                    map[s[windowEnd++] - 'a']--;
                    // window size equal to size of P
                    if (windowEnd - windowStart == p.Length)
                    {
                        result.Add(windowStart);
                    }
                }
                // window is of size 0
                else if (windowStart == windowEnd)
                {
                    windowStart++;
                    windowEnd++;
                }
                // decrease window size
                else
                {
                    map[s[windowStart++] - 'a']++;
                }
            }
            return result;
        }

        public static bool CheckInclusion(string s1, string s2)
        {
            if (string.IsNullOrWhiteSpace(s1) || string.IsNullOrWhiteSpace(s2))
                return false;

            int windowStart = 0;
            int windowEnd = 0;

            int[] map = new int[26];

            foreach (var item in s2)
            {
                map[item - 'a']++;
            }

            while (windowEnd < s1.Length)
            {
                if (map[s1[windowEnd] - 'a'] > 0)
                {
                    map[s1[windowEnd++] - 'a']--;
                    if (windowEnd - windowStart == s1.Length)
                    {
                        return true;
                    }
                }
                else if (windowStart == windowEnd)
                {
                    windowStart++;
                    windowEnd++;
                }
                else
                {
                    map[s1[windowStart++] - 'a']++;
                }

            }

            return false;

        }
    }
}

