using System;

namespace BitWise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int HammingDistance(int x, int y)
        {
            int diff = x ^ y;
            int distance = 0;
            while (diff != 0)
            {
                diff = diff & diff - 1;
                distance++;
            }
            return distance;
        }

        public static int SumBitDifferences(int[] arr, int n)
        {
            int ans = 0; // Initialize result. 

            // traverse over all possible pairs. 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ans = ans + HammingDistance(arr[i], arr[j]);
                }
            }

            return ans;
        }

        public static int SumOfTwoNumbers(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            if (b == 0)
            {
                return a;
            }
            while (a != 0)
            {
                // 1. residue
                int residue = a ^ b;

                // 2. carry
                int carry = a & b;

                // 3. update a and b
                a = carry << 1;
                b = residue;
            }
            return b;
        }
    }
}
