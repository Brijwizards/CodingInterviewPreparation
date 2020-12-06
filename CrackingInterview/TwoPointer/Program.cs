using System;

namespace TwoPointer
{
    class Program
    {
        static void Main(string[] args)
        {
            TrapWater(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
        }

        public static int TrapWater(int[] height)
        {
            int capacity = 0;
            int left = 0;
            int right = height.Length - 1;
            int maxHeight = 0;
            while (left < right)
            {
                // calculate min height from left and right.
                var minHeight = Math.Min(height[left], height[right]);
                // Set the new maxheight if new min height > maxHeight.
                maxHeight = Math.Max(maxHeight, minHeight);
                if (height[left] < height[right])
                {
                    // Subtract the left height from maxHeight to get the trapped water.
                    capacity = capacity + maxHeight - height[left];
                    left++;
                }
                else
                {
                    // Subtract the right height from maxHeight to get the trapped water.
                    capacity = capacity + maxHeight - height[right];
                    right--;
                }
            }
            return capacity;
        }
    }
}
