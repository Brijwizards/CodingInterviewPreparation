using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Fact(int n)
        {
            int fact = 0;
            if (n == 1)
            {
                return 1;
            }
            fact = n * Fact(n - 1);
            return fact;
        }

        public static string NumberToWords(int num)
        {
            if (num == 0) return "Zero";
            return Helper(num);
        }
        private static string Helper(int num)
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

        // Recursive function to print the  
        // pattern without any extra variable 
        public static void PrintPattern(int n)
        {

            // Base case (When n becomes 0 or  
            // negative) 
            if (n == 0 || n < 0)
            {
                Console.Write(n + " ");
                return;
            }

            // First print decreasing order 
            Console.Write(n + " ");

            PrintPattern(n - 5);

            // Then print increasing order 
            Console.Write(n + " ");
        }
    }
}
