using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Search(new int[]{ 4,5,6,7,0,1,2}, 0);
            //MyPower(2.0, 5);
            //MyPowerRecursive(2.0, 5);
            Sqrt(5);
            MyPower(2.0, 10);
        }

        public static int PerfectSqrt(int a)
        {
            if (a == 0 || a == 1) return a;

            int left = 1, right = a, ans = 0;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid <= a / mid)
                {
                    left = mid + 1;
                    ans = mid;
                }
                else
                {
                    right = mid - 1;
                }
                if (ans * ans == a)
                { return 1; }
            }
            return ans;
        }

        public static int Sqrt(int a)
        {
            if (a == 0 || a == 1) return a;

            int left = 1, right = a, ans = 0;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid <= a / mid)
                {
                    left = mid + 1;
                    ans = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return ans;
        }

        public static double MyPower(double x, int n)
        {
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }
            double ans = 1;
            //double current_product = x;
            for (long i = N; i > 0; i /= 2)
            {
                if ((i % 2) == 1)
                {
                    ans = ans * x;
                }
                x = x * x;
            }
            return ans;
        }

        public static double MyPowerRecursive(double x, int n)
        {
            return MyPowerUtil(x, n);
        }

        public static double MyPowerUtil(double x, int n)
        {
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                //N = -N;
            }
            if (n == 0)
            {
                return 1.0;
            }
            double result = MyPowerUtil(x * x, n / 2);
            if (n % 2 == 1)
            {
                result = result * x;
            }

            return result;
        }

        public static int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if(nums[mid] == target)
                {
                    return mid;
                }
                if (nums[left] <= nums[mid])
                {
                    if (nums[left] <= nums[mid] && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid - 1;
                    }
                }
                if (nums[right] >= nums[mid])
                {
                    if (nums[right] >= nums[mid] && target > nums[mid])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

            }

            return -1;
        }
    }
}
