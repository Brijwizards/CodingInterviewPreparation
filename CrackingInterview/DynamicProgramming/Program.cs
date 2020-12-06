using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Rob2(new int[] { 1, 2, 1, 1 });
        }

        public static int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return nums[0];

            //int[] dp = new int[nums.Length];      

            //dp[0] = nums[0];
            //dp[1] = Math.Max(nums[0], nums[1]);

            int previousSum = nums[0];
            int currentSum = Math.Max(nums[0], nums[1]); ;


            for (int i = 2; i < nums.Length; i++)
            {
                //dp[i] = Math.Max(nums[i] + dp[i-2], dp[i-1] ); 
                var temp = Math.Max(nums[i] + previousSum, currentSum);
                previousSum = currentSum;
                currentSum = temp;

            }
            return currentSum;
        }
        public static int Rob2(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return nums[0];

            if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);

            int length = nums.Length;
            var max1 = RobHouse(nums, 0, length - 2);
            var max2 = RobHouse(nums, 1, length - 1);

            return Math.Max(max1, max2);
        }

        public static int RobHouse(int[] nums, int start, int end)
        {
            int previousSum = 0;
            int currentSum = 0;
            for (int i = start; i <= end; i++)
            {
                var temp = Math.Max(nums[i] + previousSum, currentSum);
                previousSum = currentSum;
                currentSum = temp;

            }

            return currentSum;
        }

        public static int CoinChange2(int amount, int[] coins)
        {
            int len = coins.Length;
            int[] comb = new int[amount + 1];
            comb[0] = 1;
            for (int i = 0; i < len; i++)
            {
                int num = coins[i];
                for (int j = num; j <= amount; j++)
                {
                    comb[j] = comb[j] + comb[j - num];
                }
            }

            return comb[amount];
        }

        public int CoinChnage(int[] coins, int amount, int[] dp)
        {
            if (amount == 0)
                return 0;
            if (amount < 0) return -1;
            if (dp[amount - 1] != 0)
                return dp[amount - 1];

            int minValue = int.MaxValue;
            foreach (var coin in coins)
            {
                int difference = CoinChnage(coins, amount - coin, dp);

                if (difference >= 0 && difference < minValue)
                    minValue = 1 + difference;
            }
            dp[amount - 1] = minValue == int.MaxValue ? -1 : minValue;

            return dp[amount - 1];
        }

        public static void Fabonacci(int number)
        {
            int[] fabArray = new int[number + 1];
            fabArray[0] = 0;
            fabArray[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                fabArray[i] = fabArray[i - 2] + fabArray[i - 1];
            }
            for (int i = 1; i <= fabArray.Length - 1; i++)
            {
                Console.WriteLine(fabArray[i]);
                //Console.Read();
            }
        }

        public static bool WordBreak(string s, IList<string> wordDict)
        {
            int len = s.Length;
            bool[] f = new bool[len + 1];
            f[0] = true;
            for (int i = 1; i < len + 1; i++)
                for (int j = 0; j < i; j++)
                    if (f[j] && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        f[i] = true;
                        break;
                    }
            return f[len];
        }

        public static int SuperEggDrop(int K, int N)
        {
            int[,] dp = new int[N + 1, K + 1];
            int m = 0;
            while (dp[m, K] < N)
            {
                ++m;
                for (int k = 1; k <= K; ++k)
                    dp[m, k] = dp[m - 1, k - 1] + dp[m - 1, k] + 1;
            }
            return m;
        }


    }
}
