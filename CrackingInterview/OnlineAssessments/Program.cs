using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineAssessments
{
    class Program
    {
        static void Main(string[] args)
        {           
            MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" });
            var map = new Dictionary<int, List<IList<int>>>();
            var list = new List<IList<int>>();
            map.Add(1, new List<IList<int>> { new List<int> { 1, 2 } });
            var index = map.Keys.ToList().IndexOf(1);
            list = new List<IList<int>> { new List<int> { 1, 2 } };
            list.Add(new List<int> { 3, 4 });
            //Console.WriteLine("Hello World!");
            //PrimeAirRoute(new List<IList<int>> { new List<int> { 1,2}, new List<int> {2,4 }, new List<int> {3,6 } },
            //    new List<IList<int>> { new List<int> {1,2 }}, 7);

            //PrimeAirRoute(new List<IList<int>> { new List<int> { 1, 3 }, new List<int> { 2, 5 }, new List<int> { 3, 7 }, new List<int> { 4, 10 } },
            //   new List<IList<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 4 }, new List<int> { 4, 5 } }, 10);

            //PrimeAirRoute(new List<IList<int>> { new List<int> { 1, 8 }, new List<int> { 2, 15 }, new List<int> { 3, 9 }},
            //       new List<IList<int>> { new List<int> { 1, 8 }, new List<int> { 2, 11 }, new List<int> { 3, 12 }}, 20);

            //ConnectSticks(new int[] { 2, 4, 3 });
            // IsWinner(new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } }, new string[] {"orange", "apple", "apple", "banana", "orange", "banana" });

            //NumPairsDivisibleBy60(new int[] { 30, 20, 150, 100, 40 });
            //ItemsInContainer("|**|*|*", new int[] {1,1 }, new int[] {5,6 });
            // ItemsInContainer("|**|*|*", new int[] { 0, 0 }, new int[] { 5, 6 });
            //CountComponents(5, new int[][] { new int[] { 0, 1 }, new int[] {1,2}, new int[] {3,4 } });
            //CalculateAverage(new int[][] { new int[] { 4,4}, new int[] { 1, 2 }, new int[] { 3, 6 } });
            //SortWordLexicoGraphically("anacell", "deltacellular");
            //          TopKFrequentWords(new List<string> { "anacell", "betacellular", "cetracular", "deltacellular", "eurocell" }, new List<string> {"I love anacell Best services; Best services provided by anacell",
            //"betacellular has great services",
            //"deltacellular provides much better services than betacellular",
            //"cetracular is worse than anacell",
            //"Betacellular is better than deltacellular.", }, 2);
            ReorderLogFiles(new string[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" });
        }

        public static string MostCommonWord(string paragraph, string[] banned)
        {
            HashSet<string> set = new HashSet<string>(banned);
            var test = paragraph.Replace("!", " ")
                                         .Replace("?", " ")
                                         .Replace("'", " ")
                                         .Replace(",", " ")
                                         .Replace(";", " ")
                                         .Replace(".", " ")
                                         .ToLower()
                                         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .GroupBy(x => x)
                                         .OrderByDescending(x => x.Count())
                                         .Select(x => x.Key);
            foreach (var str in paragraph.Replace("!", " ")
                                         .Replace("?", " ")
                                         .Replace("'", " ")
                                         .Replace(",", " ")
                                         .Replace(";", " ")
                                         .Replace(".", " ")
                                         .ToLower()
                                         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .GroupBy(x => x)
                                         .OrderByDescending(x => x.Count())
                                         .Select(x => x.Key))
            {
                if (!set.Contains(str))
                    return str;
            }
                
            return string.Empty;
        }

        public static IList<IList<int>> PrimeAirRoute(IList<IList<int>> forwardRouteList, IList<IList<int>> returnRouteList, int maxTravelDist)
        {
            var map = new Dictionary<int, List<IList<int>>>();
            for(int i = 0; i< forwardRouteList.Count;i++)
            {
                for(int j=0;j<returnRouteList.Count;j++)
                {
                    if (!map.ContainsKey(forwardRouteList[i][1] + returnRouteList[j][1]))
                    {
                        map.Add(forwardRouteList[i][1] + returnRouteList[j][1], new List<IList<int>> { new List<int> { forwardRouteList[i][0], returnRouteList[j][0] } });
                    }
                    else
                        map[forwardRouteList[i][1] + returnRouteList[j][1]].Add(new List<int> { forwardRouteList[i][0], returnRouteList[j][0] });
                }
            }

            var minValue = int.MaxValue;
            int index = 0;
            foreach(var item in map)
            {
                var diff = maxTravelDist - item.Key;
                if(diff >=0)
                {
                    if(minValue > diff)
                    {
                        minValue = diff;
                        index = item.Key;
                    }                                    
                }
            }

            return map[index];
        }

        public static int ConnectSticks(int[] sticks)
        {
            if (sticks.Length <= 1)
                return 0;
            //var set = new SortedSet<(int a, int b)>();
            var costSet = new SortedSet<(int val, int count)>(Comparer<(int val, int count)>.Create((a, b) => {
                if (a.val != b.val) return a.val - b.val;
                return a.count - b.count;
            }));

            int rollingSum = 0, counter = 0;
            foreach (var stick in sticks)
            {
                costSet.Add((stick, counter++));
            }
            while (costSet.Count > 1)
            {
                var stick1 = costSet.Min;
                costSet.Remove(costSet.Min);
                var stick2 = costSet.Min;
                costSet.Remove(costSet.Min);

                rollingSum += stick1.val + stick2.val;
                costSet.Add((stick1.val + stick2.val, counter++));
            }

            return rollingSum;
        }

        public static int IsWinner(string[][] codeList, string[] shoppingCart)
        {
            int index = 0;
            int codeListRowIndex = 0;
            int codeListWordIndex = 0;
            int shoppingCartIndex = index;            
            while (codeListRowIndex < codeList.Length && shoppingCartIndex < shoppingCart.Length)
            {
                if (IsMatched(shoppingCart[shoppingCartIndex], codeList[codeListRowIndex][codeListWordIndex]))
                {
                    shoppingCartIndex++;
                    codeListWordIndex++;
                    if (codeListWordIndex == codeList[codeListRowIndex].Length)
                    {
                        codeListRowIndex++;
                        index = shoppingCartIndex;
                        codeListWordIndex = 0;
                    }
                }
                else
                {
                    index++;
                    shoppingCartIndex = index;
                    codeListWordIndex = 0;
                }
            }

            return codeListRowIndex == codeList.Length ? 1 : 0;
        }

        private static bool IsMatched(string source, string target)
        {
            return ("anything" == target || target == source);
        }

        public static int NumPairsDivisibleBy60(int[] time)
        {
            int[] remainders = new int[60];
            int count = 0;
            foreach (var item in time)
            {
                if (item % 60 == 0)
                { // check if a%60==0 && b%60==0
                    count += remainders[0];
                }
                else
                { // check if a%60+b%60==60
                    count += remainders[60 - item % 60];
                }
                remainders[item % 60]++; // remember to update the remainders
            }
            return count;
        }

        public static int[] ItemsInContainer(string str, int[] startIndex, int[] endIndex)
        {
            // S = "|**|*|*";
            // Start index = [1,1]
            // End index =[5,6]
            int count = 0;
            int start = startIndex[0] - 1; ;
            int index = 0;
            char currentPipe = ' ';
            var length = startIndex[1] > endIndex[1] ? startIndex[1] : endIndex[1];
            int[] indeces = new int[startIndex.Length];
            Stack<char> stack = new Stack<char>();
            while(start < length)
            {
                if(str[start] == '|')
                {                   
                    if (stack.Count != 0 && str[start] ==  '|')
                    {
                        currentPipe = stack.Pop();
                    }
                    
                    if(currentPipe == str[start])
                    {
                        indeces[index] = count;
                        index++;
                    }
                    stack.Push(str[start]);

                }
                if (str[start] == '*')
                {
                    count++;
                }
                start++;
            }
            return indeces;
        }

        private static List<int> itemContainerCount(string str, int[] start, int[] end)
        {
            List<int> itemCount = new List<int>();

            if (start == null || end == null || start.Length == 0 || str.Length < 1 || str == null)
            {
                itemCount.Add(0);
                return itemCount;
            }

            for (int i = 0; i < start.Length; i++)
            {
                string sSub = str.Substring(start[i] - 1, end[i]);
                Stack<char> charMem = new Stack<char>();

                char lastPopped = '*';
                int count = 0;

                for (int sIndex = 0; sIndex < sSub.Length; sIndex++)
                {
                    char currChar = sSub[sIndex];

                    if (currChar == '|')
                    {
                        while (charMem.Count != 0)
                        {
                            lastPopped = charMem.Pop();
                            if (lastPopped == '*')
                                count++;
                        }
                    }
                    charMem.Push(currChar);

                    if (lastPopped == '*')
                        count = 0;
                }

                if (lastPopped != '*')
                    itemCount.Add(count);
            }

            if (itemCount.Count() == 0)
                itemCount.Add(0);

            return itemCount;
        }

        public static int CountComponents(int n, int[][] edges)
        {
            int [] parent = new int[n];
            var set = new HashSet<int>();

            // Fill the parent with its own subset e.g. Node 0 has parents zero.
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
            }

            // Iterate through the edges.
            for (int i = 0; i < edges.Length; ++i)
            {
                // Get the union of two edges. Means assign the parents one node to other.
                var edge = edges[i];
                Union(edge[0], edge[1], parent);
            }

            // Find unique  parents. Means a value is equal to its index.
            for (int j = 0; j < n; j++)
            {
                set.Add(Find(j, parent));
            }

            return set.Count;
        }

        private static int Find(int node, int[] parent)
        {
            if (parent[node] != node)
            {
                parent[node] = Find(parent[node], parent);
            }
            return parent[node];
        }

        private static void Union(int x, int y, int[] parent)
        {
            int xFind = Find(x, parent);
            int yFind = Find(y, parent);

            if (xFind == yFind)
            {
                return;
            }
            parent[yFind] = xFind;
        }

        public static List<String> LargestItemAssociation(List<PairString> itemAssociation)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach (var pair in itemAssociation)
            {
                map.TryAdd(pair.first, new List<string>());
                map.TryAdd(pair.second, new List<string>());
                map[pair.first].Add(pair.second);
                map[pair.second].Add(pair.first);
            }

            HashSet<string> visited = new HashSet<string>();
            List<List<string>> lists = new List<List<string>>();
            int max = int.MinValue;

            foreach (var key in map.Keys.OrderBy(x => x))
            {
                List<String> li = new List<String>();
                Dfs(key, map, visited, li);

                if (max < li.Count)
                {
                    max = li.Count;
                    li.Sort();
                    lists.Add(li);
                }
            }

            return lists.FirstOrDefault(x => x.Count == max);
        }

        private static void Dfs(string node, Dictionary<string, List<string>> map, HashSet<string> visited, List<String> li)
        {
            if (visited.Contains(node))
                return;

            visited.Add(node);
            li.Add(node);

            foreach (var nd in map[node])
            {
                Dfs(nd, map, visited, li);
            }
        }

        public static double CalculateAverage(int[][] reviews)
        {
            double average = 0.0;
            for(int i = 0;i<reviews.Length;i++)
            {
                var start = (double)reviews[i][0];
                var end = (double)reviews[i][1];
                average = average + (double)(start / end) * 100;
            }
            average = average / reviews.Length;
            return average;
        }

        public static List<string> TopKFrequentWords(List<string> keywords, List<string> reviews, int top)
        {
            var keywordsDictionary = new Dictionary<string, int>();
            foreach (var key in keywords)
            {
                int count = reviews.Count(x => x.ToLower().Contains(key.ToLower()));
                keywordsDictionary.Add(key, count);
            }
            var list = keywordsDictionary.OrderByDescending(x => x.Value).ThenBy(y=>y.Key).Select(x => x.Key).Take(top).ToList();
            return list;
        }

        public static string SortWordLexicoGraphically(string word, string word2)
        {
            int value = word.CompareTo(word2);
            if (value == 1)
            {
                return word2;
            }
            else if (value == -1)
            {
                return word;
            }
            return word;
        }

        public static string[] FradulentActivity(string[] logs, int k)
        {
            if (logs == null || logs.Length == 0)
                return new string[0];

            int n = logs.Length;
            List<string> ans = new List<string>();

            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (var log in logs)
            {
                PopulateMap(log, map);
            }

            return map.Where(x => x.Value >= k).OrderBy(x => x.Key).Select(x => x.Key).ToArray();
        }

        public static void PopulateMap(string str, Dictionary<string, int> map)
        {
            string[] arr = str.Split(' ');
            map.TryAdd(arr[0], 0);
            map[arr[0]]++;

            if (arr[1] != arr[0])
            {
                map.TryAdd(arr[1], 0);
                map[arr[1]]++;
            }
        }

        public static string[] ReorderLogFiles(string[] logs)
        {
            SortedList<string, string> letterLog = new SortedList<string, string>();
            List<string> digitLogs = new List<string>(),
                         result = new List<string>();

            foreach (var item in logs)
                if (item[item.IndexOf(' ') + 1] >= 'a' && item[item.IndexOf(' ') + 1] <= 'z')
                    letterLog.Add(item.Substring(item.IndexOf(' ') + 1), item);
                else
                    digitLogs.Add(item);

            foreach (var item in letterLog)
                result.Add(item.Value);

            foreach (var item in digitLogs)
                result.Add(item);

            return result.ToArray();
        }
    }

    public class PairString
    {
        public String first;
        public String second;

        public PairString(String first, String second)
        {
            this.first = first;
            this.second = second;
        }
    }
}
