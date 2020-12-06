using System;

namespace LINQOperation
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    class Program
    {
        static int SumDefault(int[] array)
        {
            /*
             *
             * Sum all numbers in the array.
             *
             * */
            return array.Sum();
        }

        static int SumAsParallel(int[] array)
        {
            /*
             *
             * Enable parallelization and then sum.
             *
             * */
            return array.AsParallel().Sum();
        }

        static void Main()
        {
			var dictionary = new Dictionary<int, int>();
			var list = new List<int>();
			for (int i = 1; i <= 10; i++)
			{
				list.Add(i);
			}
			for (int i = 1; i <= 10; i++)
			{
				dictionary.Add(i, i);
			}

			// Print dictionary.
			Console.WriteLine("Printing dictionary.");
			foreach (var item in dictionary)
			{
				Console.WriteLine("Key:{0}, value:{1}", item.Key, item.Value);
			}

			// Print List.
			Console.WriteLine("\n");
			Console.WriteLine("Printing List.");
			foreach (var item in list)
			{
				Console.WriteLine("Value:{0}", item);
			}

			// LINQ Lamda operations.

			// Sort Keys in descending order, build the list and print the Keys.
			var keys = dictionary.Keys.OrderByDescending(o => o).ToList();
			foreach (var item in keys)
			{
				Console.WriteLine(item);
			}

			// Look up element(key, value) in the dictionary at given index.
			var values = dictionary.ElementAt(3);
			Console.WriteLine(values.Key);
			Console.WriteLine(values.Value);

			// Find key, value at given  index
			var key = dictionary.ElementAt(3).Key;
			var value = dictionary.ElementAt(3).Value;

			// Find key, value at given  index
			var index = dictionary.Keys.ToList().IndexOf(5);
			var index1 = dictionary.Values.ToList().IndexOf(5);
			Console.WriteLine("Key at:{0}", index);
			Console.WriteLine("Value at:{0}", index1);
			// Top 3 Keys. LINQ Select.(Select clause)
			var top3 = dictionary.Select(x => x.Key).Take(3);
			Console.WriteLine("Top 3 kyes");
			foreach (var item in top3)
			{
				Console.WriteLine("Key:{0}", item);
			}

			// LINQ Filtering(Where clause)
			var filter = dictionary.Where(o => o.Key == 5);
			foreach (var item in filter)
			{
				Console.WriteLine("Filtered Key:{0}", item.Key);
			}

			// Return anonymous type.

			var anonymous = dictionary.Select(o => new
			{
				key = o.Key,
				value = o.Value
			});


			// Generate array.
			int[] array = Enumerable.Range(0, short.MaxValue).ToArray();

            // Test methods.
            Console.WriteLine(SumAsParallel(array));
            Console.WriteLine(SumDefault(array));

            const int m = 10000;
            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
                SumDefault(array);
            }
            s1.Stop();
            var s2 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
                SumAsParallel(array);
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
                m).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) /
                m).ToString("0.00 ns"));
            Console.Read();
        }


    }
}
