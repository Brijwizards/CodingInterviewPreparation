using System;

namespace DivideAndConquer
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3 });
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            //Merge the array.

            int m = nums1.Length;
            int n = nums2.Length;
            int l = m + n;
            int[] mergedArray = new int[l];

            int i = 0, j = 0, k = 0;

            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                {
                    mergedArray[k] = nums1[i];
                    k++;
                    i++;
                }
                else
                {
                    mergedArray[k] = nums2[j];
                    k++;
                    j++;
                }
            }

            while (i < m)
            {
                mergedArray[k] = nums1[i];
                k++;
                i++;
            }

            while (j < n)
            {
                mergedArray[k] = nums2[j];
                k++;
                j++;
            }

            var median = 0.0d;
            if (l % 2 == 0)
                median = (double)(mergedArray[k / 2] + mergedArray[k / 2 - 1]) / 2;
            else
                median = (double)(mergedArray[k / 2]);

            return median;
        }
    }
}
