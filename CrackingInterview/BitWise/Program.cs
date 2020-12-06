using System;

namespace BitWise
{
    class Program
    {
        static void Main(string[] args)
        {
            FindComplement(5);
            #region Bit Manipulation Basic Operation
            // a = 5(00000101), b = 9(00001001) 
            int a = 5, b = 9;

            Console.WriteLine("INTEGER VALUES:{0}, {1}", a , b);

            // AND operation: The result is 00000001 
            Console.WriteLine("AND Operation:{0}", a & b);

            // // OR operation: The result is 00001101 
            Console.WriteLine("OR Operation:{0}", a | b);

            // XOR operation: The result is 00001100 
            Console.WriteLine("XOR Operation:{0}", a ^ b);

            // Btiwise NOT: The result is 11111010 
            Console.WriteLine("BITWISE NOT Operation:{0}", ~a);

            // Left Shift: The result is 00010010 
            Console.WriteLine("LEFT SHIFT Operation:{0}", a << 1);

            // Shift Right: The result is 00000100 
            Console.WriteLine("RIGHT SHIFT Operation:{0}", a >> 1);
            #endregion           
        }

        public static int FindComplement(int num)
        {
            int bit = 1;
            int loopThroughBit = num;
            while (loopThroughBit != 0)
            {
                // Flip current bit.
                num = num ^ bit;

                // Prepare for next run.
                bit = bit << 1;
                loopThroughBit = loopThroughBit >> 1;
            }
            return num;
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
                // 1. residue - Addition Simulation.
                int addition = a ^ b;

                // 2. carry - Get the carry
                int carry = a & b;

                // 3. update a and b - Apply the carry to the left and assign new addition to b.
                a = carry << 1;
                b = addition;
            }
            return b;
        }
    }
}
