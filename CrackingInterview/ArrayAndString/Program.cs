using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CrackingInterview
{
    class Point
    {
        public int x, y;
    }
    class Program
    {
       
        private static int low = 0;
        private static int max = 0;
        //Rectangle rectangle = new Rectangle();
        delegate int del(int i);
        

        static void Main(string[] args)
        {
            string str = FrequencySort("tree");
            //RemoveKdigits("1432219", 3);
            // UniqueDroneId(new int[] { 2, 3, 5, 5, 3, 2, 100 });
            //CombinationSum(new int[] { 2, 3, 5 }, 8);          
            //CoinChange(new int[] { 1, 2, 5 }, 11);
            //CompareVersion("7.5.2.4", "7.5.3");
            // LengthOfLongestSubstring("abcabcbb");           
            //bool isMatch = IsMatch("aa", "*");
            //DecodeString("3[a2[c]]");
            //bool isHappy = IsHappy(19);
            //ReorderLogFiles(new string[] { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo", "a2 act car"});
            //SortWordDescending("this is_brijesh-singh singh is is");
            //GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
            //int a =FindCelebrity(3);           
            //ReverseWords(" ");

            //int target = FindNumber(new int[] { 6, 5, 3, 1 }, 1);

            //FindPairsWithGivenDifference(new int[] { 0, -1, -2, 2, 1 }, 1);
            //ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });  
            //Rotate(new int[] { -1 }, 2);
            //ModularExponential(1, 1, 5);
            #region Microsoft
            //ReverseOnlyLetters("a-bC-dEf-ghIj");
            //LongestValidParentheses(")()())");           
            //Rectangle.SetZeroes(new int[,] { { 1, 1, 1 },{ 1, 0, 1 },{ 1, 1, 1 } });
            //SortByKey(new char[] {'b','a','n','a','n','a','s' }, new char[] {'a','n','s'});
            //LadderLength("hit", "cog", new List<string> { "hot", "dot", "dog", "lot", "log", "cog" });
            //LongestPalindrome("abccccdd");
            //TitleToNumber("ZY");
            //MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            //IsAnagram("anagram", "nagaram");          
            //Foramt("The current price is {0} per ounce.", "17.00m");
            //ConcatWithUncommon("aacdb", "gafd");
            //MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });            
            //Sort0s1sAnd2s(new int[] { 0, 1, 2, 1, 0, 1 });           
            #endregion
            #region Google
           
            MergeInterval(new List<Interval> { new Interval(1, 3), new Interval(2, 6), new Interval(8, 10), new Interval(15, 18) });

            QuickSort(new int[] { 10, 7, 8, 9, 1, 5 }, 0, 5);
            FindingNumbers(new int[] { 1, 2, 3, 2, 1, 4 });
            maxIndexDiff(new int[] { 9, 2, 3, 4, 5, 6, 7, 8, 18, 0 });
            SubarraySum(new int[] { 1, 2, 3, 7, 5 }, 12);

            NumUniqueEmails(new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" });
            MergeSortedArray(new int[] {1,2}, new int[] {-2});
            LengthOfLongestSubstring("abcabcbb");           
            TrapWater(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
            TotalFruit(new int[] {0, 1, 6, 6, 4, 4, 6});

            MergeInterval(new List<Interval>(){new Interval(1,4),new Interval(4,5)});
            PlusOne(new int[]{1,9,11});
            Encode("https://leetcode.com/problems/design-tinyurl");
            KthSmallest(new int[,] { { 1, 5, 9 }, { 10, 11, 13 }, { 12, 13, 15 } }, 8);
            //Google.LetterCombinations("23");
            #endregion        
            #region Rectangle
            Rectangle l1 = new Rectangle(), r1 = new Rectangle(),
               l2 = new Rectangle(), r2 = new Rectangle();
            l1.x = 0; l1.y = 10; r1.x = 10; r1.y = 0;
            l2.x = 5; l2.y = 5; r2.x = 15; r2.y = 0;


            if (Rectangle.DoOverlap(l1, r1, l2, r2))
            {
                Console.WriteLine("Rectangle Overlap");
            }
            else
            {
                Console.WriteLine("Rectangle does not Overlap");
            }

            //Rectangle l1 = new Rectangle(0,10);           
            //Rectangle r1 = new Rectangle(10,0);
            //Rectangle l2 = new Rectangle(5,5);
            //Rectangle r2 = new Rectangle(15,0);

            //redoOverlap();
            #endregion           
            #region Array

            //Fabonacci(14);
            //ReverseOnlyLetters("a-bC-dEf-ghIj");
            //ReverseWords("Let's take LeetCode contest");
            //SortColors(new []{2,0,2,1,1,0});
            //string str = LongestPalindrome("babad");
            //PrintPattern(16);
            //Fact(5);
            //twoWaySort(new int[]{1, 2, 3, 5, 4, 7, 10});
            //ElementAppeardOnce(new []{12, 1, 12, 3, 1, 2, 3});
            //SquareRoot(9);
            //ReverseWord("i.like.this.program.very.much");

            Height[] myArray = new Height[]{
                new Height() { feet = 1, inches = 3 },
                new Height() { feet = 10, inches = 5 },
                new Height() { feet = 6, inches = 8 },
                new Height() { feet = 3, inches = 7 },
                new Height() { feet = 5, inches = 9 }
            };
            //findMax(myArray,5);
            //PrintMatrix(new int[,]{ { 1, 2,1 }, { 0, 4,2 }, { 5, 0,1 }, { 7, 8, 4 } });
            //PrintMatrix(new int[,]{ });
            //ModifyMatrix(new int[,]{{1, 0, 0, 1}, {0, 0, 1, 0},{0, 0, 0, 0}});
            //LongestCommonPrefix(new string[]{"flower","flow","flight"});
            //MissingNumber(new int[]{9,6,4,2,3,5,7,0,1});
            //SumOfTwo(new int[]{5,3,6,2,4,7},9);
            //NumberToWords(9899);
            //CountPrimes(20);
            //ShiftingLetters("abc", new int[]{3,5,9});
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>

            var numQuery = from num in numbers where (num % 2) == 0 select num;
            //HammingDistance(1, 4);
            //RemoveDuplicates(new int[] { 1, 1, 2 });
            //InsertionSort(new int[] { 12, 11, 13, 5, 6 });
            //IntegerToString(123);
            #endregion               

        }

        public static int CompareVersion(string version1, string version2)
        {
            var v1 = version1.Split('.');
            var v2 = version2.Split('.');

            var maxLen = v1.Length > v2.Length ? v1.Length : v2.Length;

            for (var i = 0; i < maxLen; i++)
            {
               
                var tmp1 = i < v1.Length ? int.Parse(v1[i]) : 0;
                var tmp2 = i < v2.Length ? int.Parse(v2[i]) : 0;

                if (tmp1 > tmp2) return 1;
                if (tmp1 < tmp2) return -1;
            }

            return 0;
        }
        public static bool IsMatch(string s, string p)
        {
            int index = 0;
            if(p.Length<s.Length && !(p.Contains("*") || p.Contains("?")))
            {
                return false;
            }
          
            for(int i=0;i<s.Length;i++)
            {
                if(s[i] == p[index])
                {
                    index++;                        
                }
                else
                {
                    i = i - index;
                    index = 0;                

                }
                if (index == s.Length)
                    return true;
            }
            return false;
        }
        public static string DecodeString(string s)
        {
            string result = string.Empty,
                   baseString = string.Empty,
                   temp = string.Empty,
                   tail = string.Empty;
            Stack<char> stack = new Stack<char>();
            int repeatCount = 0,
                digit = 0;

            foreach (var item in s)
            {
                if (item != ']')
                {
                    stack.Push(item);

                    continue;
                }
                else
                {
                    while (stack.Count != 0 && stack.Peek() != '[')
                        baseString = stack.Pop().ToString() + baseString;

                    stack.Pop();

                    while (stack.Count != 0 && stack.Peek() <= 57)
                        repeatCount = ((int)stack.Pop() - 48) * (int)Math.Pow(10, digit++) + repeatCount;

                    for (int i = 1; i <= repeatCount; i++)
                        temp += baseString;

                    if (stack.Count == 0)
                        result += temp;
                    else
                        foreach (var itemInTemp in temp)
                            stack.Push(itemInTemp);

                    baseString = string.Empty;
                    temp = string.Empty;
                    repeatCount = 0;
                    digit = 0;
                }
            }

            while (stack.Count != 0)
                tail = stack.Pop().ToString() + tail;

            return result + tail;
        }
        public static bool IsHappy(int n)
        {
            if (n <= 0) return false;
            var oneResultSet = new HashSet<int>();

            while (n != 1)
            {
                var oneResult = 0;
                while (n > 0)
                {
                    oneResult += (n % 10) * (n % 10);
                    n /= 10;
                }
                if (oneResultSet.Contains(oneResult))
                {
                    return false;
                }
                oneResultSet.Add(oneResult);
                n = oneResult;            
            }

            return true;
        }
        public static string[] ReorderLogFiles(string[] logs)
        {
            SortedList<string, List<string>> letterLog = new SortedList<string, List<string>>();
            List<string> digitLogs = new List<string>(), result = new List<string>();

            foreach (var item in logs)
                if (item[item.IndexOf(' ') + 1] >= 'a' && item[item.IndexOf(' ') + 1] <= 'z')
                {
                    var logsKey = item.Substring(item.IndexOf(' ') + 1);
                    if(!letterLog.ContainsKey(logsKey))
                    {
                        letterLog.Add(logsKey, new List<string> { item });
                    }
                    else
                    {
                        letterLog[logsKey].Add(item);                            
                    }
                    
                }                   
                else
                    digitLogs.Add(item);

            foreach (var item in letterLog)
                foreach(var list in item.Value)
                result.Add(list);

            foreach (var item in digitLogs)
                result.Add(item);

            return result.ToArray();
        }
        public static void SortWordDescending(string str)
        {
                if (string.IsNullOrWhiteSpace(str))
                    return;
                var word = new Dictionary<string, int>();
                string[] words = str.Split(new char[]  { ' ', '-', '_'});
                foreach(var item in words)
                {
                    if (!word.ContainsKey(item))
                    {
                        word.Add(item, 1);

                    }
                    else
                    {
                        word[item]++;
                    }
                }
            
                var keyCount = word.Values.ToList();
            //keyCount.Sort((a, b) => b.CompareTo(a));

            // Sorting using CompareTo(non LINQ)  and lamda expression. 
            keyCount.Sort((a, b) =>
            {
                Console.WriteLine("comparing " + a + " with " + b);             
                return b.CompareTo(a);

            });

            // Sorting using LINQ and lamda expression.
            //var sorted = keyCount.OrderByDescending(x => x).ToList();

                foreach (var value in keyCount)
                {
                    Console.WriteLine("{0}: {1}", word.FirstOrDefault(x => x.Value == value).Key, value);
                }
            }
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (string s in strs)  
            {
                string temp = string.Concat(s.OrderBy(c => c));               

                if (dict.ContainsKey(temp))
                {
                    dict[temp].Add(s);
                    continue;
                }

                dict.Add(temp, new List<string>() { s });
            }

            return new List<IList<string>>(dict.Values);
        }
        public static int FindCelebrity(int n)
        {
            int x = 0;
            for (int i = 1; i < n; i++)
            {
                if (Knows(x, i)) x = i; //x cant i could be. Process of elemination. Now check x with next i
            }
            //verify chosen x is indeed a celeb
            for (int i = 0; i < n; i++)
            {
                if (i != x && (!Knows(i, x) || Knows(x, i))) return -1;
            }
            return x;
        }
        public static bool Knows(int row, int col)
        {
            int[,] arr = new int[,] { { 1, 0, 1 },{ 1, 1, 0 },{ 0, 1, 1 } };
            for(int i =row;i<arr.GetLength(0);i++)
            {
                for (int j = col; j < arr.GetLength(1); j++)
                {
                    if(arr[i,j]==1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        public static string RemoveVowels(string S)
        {
            //var sb = new StringBuilder(S);
            if (string.IsNullOrWhiteSpace(S))
                return S;
            var sb = new StringBuilder();

            for (int i = 0; i < S.Length; i++)
            {

                if (S[i] == 'a' || S[i] == 'e'
                  || S[i] == 'i' || S[i] == 'o' || S[i] == 'u')
                {
                    continue;
                }
                sb.Append(S[i]);
            }
            
            return sb.ToString();
        }
        public static string RemoveKdigits(string num, int k)
        {
            if (num.Length == k) return "0";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < num.Length; i++)
            {
                while (k > 0 && stack.Any() && stack.Peek() > num[i])
                {
                    stack.Pop();
                    k--;
                }
                if (!(stack.Count == 0 && num[i] == '0'))
                    stack.Push(num[i]);
            }
            var charArray = stack.ToArray();
            Array.Reverse(charArray);
            num = new string(charArray);
            return num == "" ? "0" : num.Substring(0, num.Length - k);
        }
        public static int UniqueDroneId(int[] droneIdList)
        {
            if (droneIdList == null || droneIdList.Length == 0)
                return 0;
            int id = 0;
            foreach(var item in droneIdList)
            {
                id = id ^ item;
            }
            return id;
        }
        public static void InsertionSort(int[] nums)
        {
            int Key = 0;
            int j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                Key = nums[i];
                j = i - 1;
                while (j >= 0 && nums[j] > Key)
                {
                    nums[j + 1] = nums[j];
                    j = j - 1;
                }
                nums[j + 1] = Key;

            }
        }
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int j = 0;
            for (int i = 1; i <= nums.Length - 1; i++)
            {
                if (nums[i] != nums[j])
                {
                    j++;
                    nums[j] = nums[i];
                }
            }
            return j + 1;
        }       
        public static string ReverseWords(string s)
        {
            string word = string.Empty;
            string reverse = string.Empty;
            if (string.IsNullOrWhiteSpace(s))
                return s;
            string[] strArray = s.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = strArray.Length - 1; i >= 0; i--)
            {
                if (strArray[i] != "")
                {
                    sb.Append(strArray[i] + ' ');
                }
            }

            return sb.ToString().Trim();
        }
        public static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            int start = 0;
            int end = str.Length - 1;
            while (start < end)
            {
                char temp = charArray[start];
                charArray[start] = charArray[end];
                charArray[end] = temp;
                start++;
                end--;
            }
            return new string(charArray);
        }
        public static void SortColors(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                Console.WriteLine("Array is Empty");
            }
            int zeroCount = 0;
            int oneCount = 0;
            int twoCount = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCount++;
                }
                if (nums[i] == 1)
                {
                    oneCount++;
                }
                if (nums[i] == 2)
                {
                    twoCount++;
                }
            }

            for (int i = 0; i <= zeroCount - 1; i++)
            {
                nums[i] = 0;
            }
            for (int i = zeroCount; i <= (zeroCount + oneCount) - 1; i++)
            {
                nums[i] = 1;
            }
            for (int i = zeroCount + oneCount; i <= nums.Length - 1; i++)
            {
                nums[i] = 2;
            }
        }
        public static string LongestPalindrome(string str)
        {
            str = str.Trim();
            if (str.Length < 2) return str;

            for (int i = 0; i <= str.Length - 1; i++)
            {
                RetrunLowAndHigh(str, i, i, max, low);
                RetrunLowAndHigh(str, i, i + 1, max, low);
            }

            return str.Substring(low, max);
        }
        public static void RetrunLowAndHigh(string str, int start, int end, int max, int low)
        {
            while (start >= 0 && end <= str.Length - 1 && str[start] == str[end])
            {
                start--;
                end++;
            }
            if (max < end - start - 1)
            {
                max = end - start - 1;
                low = start + 1;
            }
        }

        // To do two way sort. First sort even numbers in 
        // ascending order, then odd numbers in descending 
        // order. 
        static void TwoWaySort(int[] arr)
        {
            // Current indexes from left and right 
            int l = 0, r = arr.Length - 1;

            // Count of odd numbers 
            int k = 0;

            while (l < r)
            {
                // Find first odd number from left side. 
                if (arr[l] % 2 == 1)
                {
                    l++;
                    k++;
                }

                // Find first even number from right side. 
                if (arr[r] % 2 == 0)
                {
                    r--;
                }

                // Swap odd number present on left and even 
                // number right. 
                if (l < r)
                {
                    //  swap arr[l] arr[r] 
                    int temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                }
            }

            // Sort odd number in descending order 

            Array.Sort(arr, 0, 3);
            Array.Reverse(arr, 0, 3);
            // Sort even number in ascending order 
            Array.Sort(arr, 4, arr.Length - 1);
        }

        // return max of the array 
        public static int FindMax(Height[] arr, int n)
        {
            int mx = 0;
            for (int i = 0; i < n; i++)
            {
                int temp = 12 * (arr[i].feet)
                            + arr[i].inches;
                if (temp > mx)
                {
                    mx = temp;
                }
            }
            return mx;
        }
        public static int ElementAppeardOnce(int[] nums)
        {
            int appearsOnce = 0;
            int[] test = new int[256];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                test[nums[i]]++;
            }
            for (int i = 0; i <= test.Length - 1; i++)
            {
                if (test[i] == 1)
                {
                    appearsOnce = i;
                    break;
                }
            }
            return appearsOnce;
        }
        public static int SquareRoot(int x)
        {
            // Base cases 
            if (x == 0 || x == 1)
                return x;

            long r = x;
            while (r * r > x)
                r = (r + x / r) / 2;
            return (int)r;
        }
        public static string ReverseWord(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }
            str = str.Trim();
            string word = string.Empty;
            string reverseStr = string.Empty;
            foreach (var item in str)
            {
                if (item != '.')
                {
                    word = word + item;
                }
                else
                {
                    reverseStr = word + '.' + reverseStr;
                    word = string.Empty;
                }
            }
            reverseStr = word + '.' + reverseStr;
            return reverseStr.Trim();
        }
        public static void PrintMatrix(int[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);
            if (matrix == null || matrix.Length == 0)
            {
                Console.Write("");
            }
            for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    //Console.Write(string.Format("{0} ", matrix[i, j]));
                    //Console.ReadLine();

                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
        public static void ModifyMatrix(int[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);
            int[] row = new int[rowLength];
            int[] column = new int[colLength];
            for (int i = 0; i < rowLength - 1; i++)
            {
                row[i] = 0;
            }
            for (int i = 0; i < rowLength - 1; i++)
            {
                column[i] = 0;
            }
            for (int i = 0; i <= rowLength - 1; i++)
            {
                for (int j = 0; j <= colLength - 1; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        row[i] = 1;
                        column[j] = 1;
                    }
                }
            }
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (row[i] == 1 || column[j] == 1)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            if (matrix == null || matrix.Length == 0)
            {
                Console.Write("Matrix is Empty.");
            }
            for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    //Console.Write(string.Format("{0} ", matrix[i, j]));
                    //Console.ReadLine();

                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return null;
            }
            string str = string.Empty;
            for (int i = 0; i <= strs[0].Length - 1; i++)
            {
                for (int j = 1; j <= strs.Length - 1; j++)
                {
                    if (strs[0][i] != strs[j][i] || strs[j].Length < (i + 1))
                    {
                        return str;
                    }
                }
                str = str + strs[0][i];
            }
            return str;
        }
        public static int MissingNumber(int[] nums)
        {
            int sum = 0;
            int length = nums.Length - 1;
            sum = length * (length + 1) / 2;
            if (nums == null || length == 0)
            {
                return 0;
            }
            for (int i = 0; i <= length - 1; i++)
            {
                sum = sum - nums[i];
            }
            return sum;
        }
        public static bool SumOfTwo(int[] nums, int target)
        {
            var keyPairDict = new Dictionary<int, int>();
            int difference = 0;
            foreach (var item in nums)
            {
                difference = target - item;
                if (difference < 0)
                {
                    continue;
                }
                if (!keyPairDict.ContainsKey(item))
                {
                    keyPairDict.Add(difference, item);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }       
        public static int CountPrimes(int n)
        {
            bool[] isPrime = new bool[n];
            for (int i = 2; i < n; i++)
            {
                isPrime[i] = true;
            }
            // Loop's ending condition is i * i < n instead of i < sqrt(n)
            // to avoid repeatedly calling an expensive function sqrt().
            for (int i = 2; i * i < n; i++)
            {
                if (!isPrime[i]) continue;
                for (int j = i * i; j < n; j += i)
                {
                    isPrime[j] = false;
                }
            }
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i])
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            return count;
        }
        public static string ShiftingLetters(string S, int[] shifts)
        {
            if (string.IsNullOrWhiteSpace(S) || shifts == null || shifts.Length == 0)
            {
                return string.Empty;
            }
            char[] arr = S.ToCharArray();
            int shift = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                shift = (shift + shifts[i]) % 26;
                arr[i] = (char)((arr[i] - 'a' + shift) % 26 + 'a');
            }
            return new string(arr);
        }
        public static string IntegerToString(int number)
        {
            if (number == 0)
            {
                return string.Empty;
            }
            List<int> list = new List<int>();
            while (number > 0)
            {
                list.Insert(0, number % 10);
                number = number / 10;
            }
            string stringValue = string.Empty;

            foreach (int item in list)
            {
                stringValue = stringValue + item;
            }
            return stringValue;
        }      
        public static ArrayList FindPairsWithGivenDifference(int[] arr, int k)
        {

            var list = new ArrayList();
            if (arr == null || arr.Length == 0)
            {
                return list;
            }
            var dictionary = new Dictionary<int, int>();
            //var hs = new HashSet<int>();
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (!dictionary.ContainsKey(arr[i]))
                {
                    dictionary.Add(arr[i], 1);
                }
                else { dictionary[arr[i]]++; }
            }

            for (int i = 0; i <= arr.Length - 1; i++)
            {

                if (dictionary.ContainsKey(k + arr[i]))
                {
                    list.Add(new List<int> { k + arr[i], dictionary.ElementAt(i).Key });
                }
            }
            return list;
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);
            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (i > 0 && nums[i - 1] == nums[i])
                {
                    continue;
                }

                var left = i + 1;
                var right = nums.Length - 1;
                while (left < right)
                {
                    var sum = nums[i] + nums[left] + nums[right];
                    if (sum < 0)
                    {
                        left++;
                    }
                    else if (sum > 0)
                    {
                        right--;
                    }
                    else
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }
                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }
                        left++;
                        right--;
                    }
                }
            }
            return result;
        }

        public static Dictionary<string, string> encodeUrl = new Dictionary<string, string>();
        public static string substring = string.Empty;

        public static int ModularExponential(int x, int y, int p)
        {
            //int modular = 0;
            int power = 1;
            for (int i = 1; i <= y; i++)
            {
                power = power * x;
            }
            return power % p;
        }

        public static void Rotate(int[] nums, int k)
        {
            if (nums == null || k > nums.Length)
            {
                return;
            }
            int length = nums.Length;
            int[] temp = new int[length];
            int index = 0;
            for (int j = length - k; j < length; j++)
            {
                temp[index] = nums[j];
                index++;
            }
            for (int j = 0; j < length - k; j++)
            {
                temp[index] = nums[j];
                index++;
            }
            for (int j = 0; j < length; j++)
            {
                nums[j] = temp[j];
            }
        }

        public static int NumUniqueEmails(string[] emails)
        {
            if (emails == null || emails.Length == 0)
                return 0;

            var hashset = new HashSet<string>();
            foreach (var email in emails)
            {
                //need to figure out email address
                var split = email.Split('@');
                var domainName = split[1];
                var localName = split[0];
                var userName = localName.Split('+');
                var splitWithDot = userName[0].Split('.');
                var address = string.Join("", splitWithDot);
                hashset.Add(splitWithDot + "@" + domainName);
            }

            return hashset.Count;
        }

        public static int[] MergeSortedArray(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            int totalLength = len1 + len2;
            int[] result = new int[totalLength];

            int i = 0, j = 0, k = 0;

            while (i < len1 && j < len2)
            {
                result[k++] = nums2[j] < nums1[i] ? nums2[j++] : nums1[i++];
            }

            while (i < len1)
            {
                result[k++] = nums1[i++];
            }

            while (j < len2)
            {
                result[k++] = nums2[j++];
            }
            return result;
        }


        public static int LengthOfLongestSubstring(string testString)
        {
            int longestIndex = 0;
            int tempIndex = 0;
            int MaxIndex = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i <= testString.Length - 1; i++)
            {
                if (dic.ContainsKey(testString[i]))
                {
                    int currentIndex = dic[testString[i]] + 1;
                    if (currentIndex > tempIndex)
                        tempIndex = currentIndex;

                }
                dic[testString[i]] = i;
                MaxIndex = i - tempIndex + 1;
                if (MaxIndex > longestIndex)
                    longestIndex = MaxIndex;
            }
            return tempIndex;
        }

        public static int TrapWater(int[] height)
        {
            var n = height.Length;
            var l = 0;
            var r = n - 1;
            var capacity = 0;
            var maxHeight = 0;
            var minHeight = 0;
            while (l < r)
            {
                var left = height[l];
                var right = height[r];
                minHeight = Math.Min(left, right);
                maxHeight = Math.Max(maxHeight, minHeight);
                if (left < right)
                {
                    l++;
                    capacity += maxHeight - left;
                }
                else
                {
                    r--;
                    capacity += maxHeight - right;
                }
            }
            return capacity;

        }

        public static int TotalFruit(int[] tree)
        {
            int currSum = 0;
            int maxLength = 0;
            int keyToremove = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int end = 0; end <= tree.Length - 1; end++)
            {
                currSum = 0;
                if (!map.ContainsKey(tree[end]))
                {
                    if (map.Count() == 2)
                    {
                        keyToremove = map.ElementAt(0).Key;
                    }
                    map.Add(tree[end], 1);
                }
                else
                {
                    map[tree[end]]++;
                }
                if (map.Count() > 2)
                {
                    map.Remove(keyToremove);
                }
                foreach (var item in map.Values)
                {
                    currSum = currSum + item;
                    if (currSum > maxLength)
                    {
                        maxLength = currSum;
                    }
                }
            }
            return maxLength;
        }

        public static IList<Interval> MergeInterval(IList<Interval> intervals)
        {
            IList<Interval> res = new List<Interval>();
            foreach (Interval curr in intervals.OrderBy(x => x.start))
            {
                if (res.Count == 0 || res[res.Count - 1].end < curr.start) res.Add(new Interval(curr.start, curr.end));
                else res[res.Count - 1].end = Math.Max(res[res.Count - 1].end, curr.end);
            }
            return res;
        }


        public static int[] PlusOne(int[] digits)
        {
            var list = new List<int>();

            int numToAdd = 1;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] += numToAdd;

                if (digits[i] == 10)
                {
                    digits[i] -= 10;
                    numToAdd = 1;
                }
                else
                {
                    numToAdd = 0;
                }

                list.Insert(0, digits[i]);
            }
            if (numToAdd > 0)
            {
                list.Insert(0, 1);
            }
            return list.ToArray();
        }

        public static string Encode(string longUrl)
        {
            substring = longUrl.Substring(longUrl.Length - 4, 4);
            string shortUrl = longUrl.Substring(0, longUrl.Length - 4);
            encodeUrl.Add("shortUrl", shortUrl);
            return Decode(shortUrl);
        }

        // Decodes a shortened URL to its original URL.
        public static string Decode(string shortUrl)
        {
            var longUrl = encodeUrl["shortUrl"] + substring;
            return longUrl;
        }

        public static IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            if (digits == null || digits.Length == 0) return result;

            var map = new Dictionary<char, List<char>>();
            map.Add('2', new List<char> { 'a', 'b', 'c' });
            map.Add('3', new List<char> { 'd', 'e', 'f' });
            map.Add('4', new List<char> { 'g', 'h', 'i' });
            map.Add('5', new List<char> { 'j', 'k', 'l' });
            map.Add('6', new List<char> { 'm', 'n', 'o' });
            map.Add('7', new List<char> { 'p', 'q', 'r', 's' });
            map.Add('8', new List<char> { 't', 'u', 'v' });
            map.Add('9', new List<char> { 'w', 'x', 'y', 'z' });
            result.Add("");

            foreach (var d in digits)
            {
                var new_result = new List<string>();
                var alphabates = map[d];

                foreach (var r in result)
                {
                    foreach (var c in alphabates)
                    {
                        new_result.Add(r + c);
                    }
                }
                result = new_result;
            }
            return result;
        }

        public static int KthSmallest(int[,] matrix, int k)
        {

            int h = matrix.GetLength(0);
            List<int> list = new List<int>();
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                    list.Add(matrix[i, j]);
            }
            list.Sort();
            return list[k - 1];
        }

        public static int SubarraySum(int[] nums, int k)
        {
            int count = 0, sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, 1);
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (map.ContainsKey(sum - k))
                    count += map[sum - k];

                if (map.ContainsKey(sum))
                {
                    map[sum] += 1;
                }
                else
                {
                    map.Add(sum, 1);
                }
            }
            return count;
        }

        public static int maxIndexDiff(int[] arr)
        {
            int maxDiff;
            int n = arr.Length;
            int[] RMax = new int[n];
            int[] LMin = new int[n];

            // Construct LMin[] such that LMin[i]  
            // stores the minimum value 
            // from (arr[0], arr[1], ... arr[i])  
            LMin[0] = arr[0];
            for (int left = 1; left < n; ++left)
                LMin[left] = Math.Min(arr[left], LMin[left - 1]);

            // Construct RMax[] such that  
            // RMax[j] stores the maximum value 
            // from (arr[j], arr[j+1], ..arr[n-1])  
            RMax[n - 1] = arr[n - 1];
            for (int right = n - 2; right >= 0; --right)
                RMax[right] = Math.Max(arr[right], RMax[right + 1]);

            // Traverse both arrays from left  
            // to right to find optimum j - i 
            // This process is similar to merge()  
            // of MergeSort  
            int i = 0; int j = 0; maxDiff = -1;
            while (j < n && i < n)
            {
                if (LMin[i] < RMax[j])
                {
                    maxDiff = Math.Max(maxDiff, j - i);
                    j = j + 1;
                }
                else
                    i = i + 1;
            }

            return maxDiff;
        }

        public static List<int> FindingNumbers(int[] nums)
        {
            var list = new List<int>();
            if (nums == null || nums.Length == 0)
            {
                return list;
            }
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], 1);
                }
                else
                {
                    dictionary[nums[i]]++;
                }
            }

            foreach (var item in dictionary)
            {
                if (item.Value == 1)
                {
                    list.Add(item.Key);
                }
            }
            list.Sort();
            return list;
        }

        /* This function takes last element as pivot, 
        places the pivot element at its correct 
        position in sorted array, and places all 
        smaller (smaller than pivot) to left of 
        pivot and all greater elements to right 
        of pivot */
        public static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        public static void SetZeroes(int[,] matrix)
        {
            for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        if (i >= 0 && i < matrix.GetLength(0) && j >= 0 && j < matrix.GetLength(1))
                        {
                            matrix[i - 1, j] = 0;
                            matrix[i + 1, j] = 0;
                            matrix[i, j - 1] = 0;
                            matrix[i, j + 1] = 0;
                        }

                        //break;
                    }

                }
            }

        }
        public static void Sort0s1sAnd2s(int[] a)
        {
            int lo = 0;
            int hi = a.Length - 1;
            int mid = 0, temp = 0;
            while (mid <= hi)
            {
                if (a[mid] == 0)
                {
                    temp = a[lo];
                    a[lo] = a[mid];
                    a[mid] = temp;
                    lo++;
                    mid++;
                }
                if (a[mid] == 1)
                {
                    mid++;
                }
                if (mid <= hi)
                {
                    temp = a[mid];
                    a[mid] = a[hi];
                    a[hi] = temp;
                    hi--;
                }
            }
        }

        public string NumberToWords(int num)
        {
            if (num == 0) return "Zero";
            return Helper(num);
        }

        private string Helper(int num)
        {

            string[] belowTen = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] belowTwenty = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] belowHundred = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string result = string.Empty; ;
            if (num < 10) result = belowTen[num];
            else if (num < 20) result = belowTwenty[num - 10];
            else if (num < 100) result = belowHundred[num / 10] + " " + Helper(num % 10);
            else if (num < 1000) result = Helper(num / 100) + " Hundred " + Helper(num % 100);
            else if (num < 1000000) result = Helper(num / 1000) + " Thousand " + Helper(num % 1000);
            else if (num < 1000000000) result = Helper(num / 1000000) + " Million " + Helper(num % 1000000);
            else result = Helper(num / 1000000000) + " Billion " + Helper(num % 1000000000);
            return result.Trim();
        }

        public static int MaxArea(int[] height)
        {
            if (height.Length <= 1) return 0;

            var left = 0;
            var right = height.Length - 1;
            var result = 0;
            while (left < right)
            {
                var h = 0;
                if (height[left] < height[right])
                {
                    h = height[left];
                    left++;
                }
                else
                {
                    h = height[right];
                    right--;
                }
                result = Math.Max(h * (right - left + 1), result);
            }

            return result;

        }

        public static string ConcatWithUncommon(string first, string second)
        {
            //string result = string.Empty;
            var map = new Dictionary<char, int>();
            for (int i = 0; i <= first.Length - 1; i++)
            {
                if (!map.ContainsKey(first[i]))
                {
                    map.Add(first[i], 1);
                }
                else
                {
                    map[first[i]]++;
                }
            }
            // var rem = string.Empty;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= second.Length - 1; i++)
            {
                if (map.ContainsKey(second[i]))
                {
                    map.Remove(second[i]);
                }
                else
                {
                    sb.Append(second[i]);
                }
            }
            foreach (var item in map)
            {
                sb.Insert(0, item.Key);
            }
            return sb.ToString();
        }

        public static string Foramt(string str, string constant)
        {
            string[] words = str.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (var word in words)
            {
                sb.Append(word + " ");
                if (word == "{0}")
                {
                    sb.Replace("{0}", constant);
                }
            }
            return sb.ToString().Trim();
        }

        public static string ReverseOnlyLetters(string S)
        {
            int start = 0;
            int end = S.Length - 1;
            char[] stringArray = S.ToCharArray();
            while (start < end)
            {
                if (!(65 <= stringArray[start] && stringArray[start] <= 90) && !(97 <= stringArray[start] && stringArray[start] <= 122))
                {
                    start++;
                }
                else if (!(65 <= stringArray[end] && stringArray[end] <= 90) && !(97 <= stringArray[start] && stringArray[end] <= 122))
                {
                    end--;
                }
                else
                {
                    char temp = stringArray[start];
                    stringArray[start] = stringArray[end];
                    stringArray[end] = temp;
                    start++;
                    end--;
                }

            }
            return new string(stringArray);
        }

        public static int LongestValidParentheses(string s)
        {
            var map = new Dictionary<char, char>();
            var stack = new Stack<char>();
            map.Add(')', '(');
            int count = 0;
            foreach (var item in s)
            {
                if (map.ContainsKey(item) && stack.Count != 0)
                {
                    if (map[item] == stack.Pop())
                    {
                        count = count + 2;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    stack.Push(item);
                }
            }
            return count;
        }

        public static void NextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            while (i >= 0 && nums[i + 1] <= nums[i])
            {
                i--;
            }
            if (i >= 0)
            {
                int j = nums.Length - 1;
                while (j >= 0 && nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
            }
            Reverse(nums, i + 1);
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            var map = new Dictionary<char, int>();

            foreach (var item in s)
            {
                if (!map.ContainsKey(item))
                {
                    map.Add(item, 1);
                }
                else
                {
                    map[item]++;
                }
            }
            foreach (var item in t)
            {
                if (!map.ContainsKey(item))
                {
                    return false;
                }
                else
                {
                    map[item]--;
                }
            }
            foreach (var item in map)
            {

                if (item.Value > 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int MaxProfit(int[] prices)
        {
            int maxprofit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    maxprofit += prices[i] - prices[i - 1];
            }
            return maxprofit;
        }

        public static int TitleToNumber(string s)
        {
            var sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum = sum * 26 + s[i] - 'A' + 1;
            }
            return sum;
        }       

        private static void Reverse(int[] nums, int start)
        {
            int i = start, j = nums.Length - 1;
            while (i < j)
            {
                Swap(nums, i, j);
                i++;
                j--;
            }
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (!wordList.Contains(endWord))
                return 0;
            HashSet<string> dict = new HashSet<string>(wordList);

            Queue<string> queue = new Queue<string>();
            queue.Enqueue(beginWord);
            int dis = 1;

            while (queue.Count > 0)
            {
                int cnt = queue.Count;
                for (int i = 0; i < cnt; i++)
                {
                    var cur = queue.Dequeue();
                    if (cur == endWord)
                        return dis;

                    GetNext(cur, queue, dict);
                }
                dis++;
            }

            return 0;
        }

        public static void GetNext(string cur, Queue<string> queue, HashSet<string> dict)
        {
            var start = cur.ToCharArray();
            for (int i = 0; i < start.Length; i++)
            {
                var tmp = start[i];
                for (int j = 0; j < 26; j++)
                {
                    if (tmp == 'a' + j) continue;
                    start[i] = (char)('a' + j);
                    var newWord = new string(start);
                    if (dict.Contains(newWord))
                    {
                        queue.Enqueue(newWord);
                        dict.Remove(newWord);
                    }
                }
                start[i] = tmp;
            }
        }

        public static string SortByKey(char[] str, char[] pat)
        {
            // Create a count array stor 
            // count of characters in str. 
            int[] count = new int[26];

            // Count number of occurrences of 
            // each character in str. 
            for (int i = 0; i < str.Length; i++)
            {
                count[str[i] - 'a']++;
            }

            // Traverse the pattern and print every characters 
            // same number of times as it appears in str. This 
            // loop takes O(m + n) time where m is length of 
            // pattern and n is length of str. 
            int index = 0;
            for (int i = 0; i < pat.Length; i++)
            {
                for (int j = 0; j < count[pat[i] - 'a']; j++)
                {
                    str[index++] = pat[i];
                }
            }

            return str.ToString();
        }

        //public static string FrequencySort(string str)
        //{
        //    // Create a count array stor 
        //    // count of characters in str. 
        //    int[] count = new int[26];

        //    // Count number of occurrences of 
        //    // each character in str. 
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        count[str[i] - 'a']++;
        //    }

        //    char[] frequencyArray = new char[str.Length];
        //    //int[] array = new int[] { };
        //    // Traverse the pattern and print every characters 
        //    // same number of times as it appears in str. This 
        //    // loop takes O(m + n) time where m is length of 
        //    // pattern and n is length of str. 
        //    int index = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        for (int j = 0; j < count[str[i] - 'a'] && index< str.Length; j++)
        //        {
        //            frequencyArray[index++] = str[i];
        //        }
        //    }

        //    var result = frequencyArray.Reverse();
        //    return result.ToString();
        //}

        public static string FrequencySort(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return s;

            var map = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (!map.ContainsKey(item))
                {
                    map.Add(item, 1);
                }
                else
                {
                    map[item]++;
                }
            }

            var sortedWord = map.OrderByDescending(x => x.Value);
            var result = string.Empty;
            foreach (var item in sortedWord)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    result = result + item.Key;
                }
            }

            //char[] arr = result.ToCharArray();
            //Array.Reverse(arr);
            // Console.WriteLine(new String((arr)));
            //char[] frequencySort = result.ToCharArray().Reverse();
            //string frequencySort = result.Reverse().ToString();
            //var keyCount = map.Values.ToList();

            //foreach (var value in keyCount)
            //{
            //    map.FirstOrDefault(x => x.Value == value);
            //}         

            return result;
        }

        /// <summary>
        /// Struct.
        /// </summary>
        public struct Height
        {
            public int feet;
            public int inches;
        };        
    }

    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }  

    public class Rectangle
    {
        public int x;
        public int y;     

        public static bool DoOverlap(Rectangle l1, Rectangle r1, Rectangle l2, Rectangle r2)
        {
            if (l1 == null || r1 == null || l2 == null || r2 == null)
            {
                return false;
            }
            if (l1.x > r2.x || l2.x > r1.x)
            {
                return false;

            }
            if (l1.y < r2.y || l2.y < r1.y)
            {
                return false;

            }
            return true;
        }
       
    }
}
