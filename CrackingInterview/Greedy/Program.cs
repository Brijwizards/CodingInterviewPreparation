using System;
using System.Collections.Generic;
using System.Data;

namespace Greedy
{
    class Program
    {
        static void Main(string[] args)
        {
			//Console.WriteLine("Hello World!");
			//Stack<int> stack = new Stack<int>();
			//Queue<int> queue = new Queue<int>();
			//queue.Enqueue(1);
			//queue.Enqueue(2);
			//var a = queue.Min
			//PartitionLabels("ababcbacadefegdehijhklij");
			ConnectSticks(new int[] { 1, 8, 3, 5 });
        }

		public static IList<int> PartitionLabels(string S)
		{
			if (S == null || S.Length == 0)
				return null;

			// Need only 26 spaces since we are dealing with only 26 lowercase letters.
			int[] partition = new int[26];

			for (int i = 0; i < S.Length; i++)
			{
				// Store/set the index of last occurence of each letter.
				partition[S[i] - 'a'] = i;
			}

			int start = 0;
			int end = 0;
			var list = new List<int>();

			for (int i = 0; i < S.Length; i++)
			{
				// Get the  index of the last occurence of each letter  in current partition.
				end = Math.Max(end, partition[S[i] - 'a']);

				// If current i is equal to the last occurence of the letter in the current partition.
				if (i == end)
				{
					list.Add(end - start + 1);
					// set the new start once current partition is exhausted.
					start = end + 1;
				}
			}

			return list;
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

		public static int ConnectSticksWithPriorityQueue(int[] sticks)
        {
			PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

			int minCost = 0;
            if (sticks == null || sticks.Length == 0)
                return 0;
            //SortedSet<int> soretedSet = new SortedSet<int>();
            foreach(var item in sticks)
            {
				priorityQueue.Enqueue(item);
            }

            while(priorityQueue.Count() > 1)
            {               
                var sum = priorityQueue.Dequeue() + priorityQueue.Dequeue();
                minCost = minCost + sum;
				priorityQueue.Enqueue(sum);
            }
            return minCost;
        }
	}

// From http://visualstudiomagazine.com/articles/2012/11/01/priority-queues-with-c.aspx
public class PriorityQueue<T> where T : IComparable<T>
	{
		private List<T> data;

		public PriorityQueue()
		{
			this.data = new List<T>();
		}

		public void Enqueue(T item)
		{
			data.Add(item);
			int ci = data.Count - 1; // child index; start at end
			while (ci > 0)
			{
				int pi = (ci - 1) / 2; // parent index
				if (data[ci].CompareTo(data[pi]) >= 0)
					break; // child item is larger than (or equal) parent so we're done
				T tmp = data[ci];
				data[ci] = data[pi];
				data[pi] = tmp;
				ci = pi;
			}
		}

		public T Dequeue()
		{
			// assumes pq is not empty; up to calling code
			int li = data.Count - 1; // last index (before removal)
			T frontItem = data[0];   // fetch the front
			data[0] = data[li];
			data.RemoveAt(li);

			--li; // last index (after removal)
			int pi = 0; // parent index. start at front of pq
			while (true)
			{
				int ci = pi * 2 + 1; // left child index of parent
				if (ci > li)
					break;  // no children so done
				int rc = ci + 1;     // right child
				if (rc <= li && data[rc].CompareTo(data[ci]) < 0) // if there is a rc (ci + 1), and it is smaller than left child, use the rc instead
					ci = rc;
				if (data[pi].CompareTo(data[ci]) <= 0)
					break; // parent is smaller than (or equal to) smallest child so done
				T tmp = data[pi];
				data[pi] = data[ci];
				data[ci] = tmp; // swap parent and child
				pi = ci;
			}
			return frontItem;
		}

		public T Peek()
		{
			T frontItem = data[0];
			return frontItem;
		}

		public int Count()
		{
			return data.Count;
		}

		public override string ToString()
		{
			string s = "";
			for (int i = 0; i < data.Count; ++i)
				s += data[i].ToString() + " ";
			s += "count = " + data.Count;
			return s;
		}

		public bool IsConsistent()
		{
			// is the heap property true for all data?
			if (data.Count == 0)
				return true;
			int li = data.Count - 1; // last index
			for (int pi = 0; pi < data.Count; ++pi)
			{ // each parent index
				int lci = 2 * pi + 1; // left child index
				int rci = 2 * pi + 2; // right child index

				if (lci <= li && data[pi].CompareTo(data[lci]) > 0)
					return false; // if lc exists and it's greater than parent then bad.
				if (rci <= li && data[pi].CompareTo(data[rci]) > 0)
					return false; // check the right child too.
			}
			return true; // passed all checks
		}
		// IsConsistent
	}
}
