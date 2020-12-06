using System;
using System.Collections.Generic;
using System.Linq;

namespace BackTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateParenthesis(3);
            FindAnagrams("eidboaoo", "ab");
        }

        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> list = new List<string>();
            BackTrack(list, "", 0, 0, n);
            return list;
        }
        public static void BackTrack(IList<string> list, string str, int open, int close, int max)
        {
            if (str.Length == 2 * max)
            {
                list.Add(str);
                return;

            }
            if (open < max)
            {
                BackTrack(list, str + "(", open + 1, close, max);
            }
            if (close < open)
            {
                BackTrack(list, str + ")", open, close + 1, max);
            }
        }

        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> perms = new List<IList<int>>();
            List<int> perm = new List<int>();
            GetPerms(perm, nums, perms);
            return perms;
        }
        public static void GetPerms(List<int> perm, int[] nums, IList<IList<int>> perms)
        {
            if (perm.Count == nums.Length)
            {
                perms.Add(new List<int>(perm));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!perm.Contains(nums[i]))
                {
                    perm.Add(nums[i]);
                    GetPerms(perm, nums, perms);
                    perm.Remove(perm.Last());
                }
            }
            return;
        }

        public static IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> allSubsets = new List<IList<int>>();
            IList<int> subset = new List<int>();
            RecursiveSubsets(0, nums, subset, allSubsets);
            return allSubsets;
        }
        public static void RecursiveSubsets(int start, int[] nums, IList<int> subset, IList<IList<int>> allSubsets)
        {
            allSubsets.Add(new List<int>(subset));
            for (int i = start; i < nums.Length; i++)
            {
                subset.Add(nums[i]);
                RecursiveSubsets(i + 1, nums, subset, allSubsets);
                subset.Remove(nums[i]);
            }
        }
               
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            IList<IList<int>> lists = new List<IList<int>>();
            Find(lists, candidates, target, 0, new List<int>());
            return lists;
        }

        public static void Find(IList<IList<int>> lists, int[] arr, int target, int start, IList<int> curr)
        {
            if (target == 0)
            {
                lists.Add(new List<int>(curr));
                return;
            }

            for (int i = start; i < arr.Length && arr[i] <= target; i++)
            {
                curr.Add(arr[i]);
                Find(lists, arr, target - arr[i], i, curr);
                curr.RemoveAt(curr.Count - 1);
            }
        }

        public static IList<IList<string>> GenerateAllPermutations(string input)
        {
            IList<IList<string>> result = new List<IList<string>>();
            List<char> perm = new List<char>();
            PermuteAll(result, perm, input);
            return result;
        }

        public static void PermuteAll(IList<IList<string>> result, IList<char> permute, string input)
        {
            if (permute.Count == input.Length)
            {
                var perm = string.Empty;
                foreach (var item in permute)
                    perm = perm + item;
                result.Add(new List<string> { perm });
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (!permute.Contains(input[i]))
                {
                    permute.Add(input[i]);
                    PermuteAll(result, permute, input);
                    permute.Remove(permute.Last());
                }
            }

            return;
        }

        public static bool FindAnagrams(string s, string p)
        {
            var indexList = new List<int>();
            var list = new List<char>();
            var result = new List<IList<string>>();

            if (string.IsNullOrWhiteSpace(p))
                return false;
            GetAllAnagrams(p, list, result);
           
            foreach (var item in result)
            {
                var index = s.IndexOf(item[0]);
                if(index >=0)
                {
                    return true;
                }
                              
            }

            return false;
        }

        public static void GetAllAnagrams(string str, List<char> list, List<IList<string>> result)
        {
            if (str.Length == list.Count)
            {
                string newString = string.Empty;
                foreach (var item in list)
                {
                    newString = newString + item;
                }
                result.Add(new List<string> { newString });
                return;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (!list.Contains(str[i]))
                {
                    list.Add(str[i]);
                    GetAllAnagrams(str, list, result);
                    list.Remove(list.Last());
                }
            }
        }
    }
}
