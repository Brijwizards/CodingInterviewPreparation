using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FindOrder(4, new int[][] { new int[] { 1, 0 }, new int[] {2,0}, new int[] {3, 1}, new int[] {3,2} });
            // Create a graph given in the above diagram
            var graph = new Graph();

            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            //graph.AddEdge(1, 2);

            graph.AddEdge(2, 5);
            graph.AddEdge(2, 6);
            graph.AddEdge(4, 7);
            graph.AddEdge(4, 8);

            graph.AddEdge(5, 9);
            graph.AddEdge(5, 10);
            graph.AddEdge(7, 11);
            graph.AddEdge(7, 12);

            foreach (var item in graph.Adj)
            {
                foreach (var value in item.Value)
                {
                    Console.WriteLine("Key: {0}, Value: {1}", item.Key, value);
                }
              
            }

            //Console.WriteLine("Following is Breadth First Traversal (starting from vertex 1)");
            //graph.BFSWalkWithStartNode(1);

            //Console.WriteLine("Following is Depth First Traversal (starting from vertex 1)");
            //graph.DFSWalkWithStartNode(1);

            Console.WriteLine("Following is Depth First Traversal USING RECURSION (starting from vertex 1)");
            graph.DFSWithRecursion(1);


        }

        static Dictionary<int, List<int>> Map = new Dictionary<int, List<int>>();
        static public bool[] Visited;
        static public bool[] CallStack;
        static public Stack<int> order = new Stack<int>();
        public static int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            Visited = new bool[numCourses];
            CallStack = new bool[numCourses];

            IntitializeMap(prerequisites);

            for (int course = 0; course < numCourses; ++course)
            {
                if (IsCyclic(course))
                    return new int[0];
            }

            int[] output = new int[order.Count];

            int pos = 0;

            while (order.Count > 0)
            {
                output[pos++] = order.Pop();
            }

            return output.Length == 0 ? new int[1] { 0 } : output;
        }
        public static bool IsCyclic(int course)
        {

            if (CallStack[course])
                return true;

            if (Visited[course])
                return false;

            Visited[course] = true;
            CallStack[course] = true;           

            if (Map.ContainsKey(course))
            {
                foreach (var child in Map[course])
                {
                    if (IsCyclic(child))
                        return true;
                }
            }

            order.Push(course);
            CallStack[course] = false;

            return false;
        }

        public static void IntitializeMap(int[][] courses)
        {

            for (int i = 0; i < courses.Length; ++i)
            {
                if (!Map.ContainsKey(courses[i][0]))
                    Map[courses[i][0]] = new List<int>();

                if (!Map.ContainsKey(courses[i][1]))
                    Map[courses[i][1]] = new List<int>();

                Map[courses[i][1]].Add(courses[i][0]);
            }
        }

        public class Graph
        {
            public Dictionary<int, HashSet<int>> Adj { get; private set; }
            public Graph()
            {
                Adj = new Dictionary<int, HashSet<int>>();
            }

            public void AddEdge(int source, int target)
            {
                if (Adj.ContainsKey(source))
                {
                    try
                    {
                        Adj[source].Add(target);
                    }
                    catch
                    {
                        Console.WriteLine("This edge already exists: " + source + " to " + target);
                    }
                }
                else
                {
                    //var hashSet = new HashSet<int>();
                    //hashSet.Add(target);
                    Adj.Add(source, new HashSet<int> { target});
                }
            }

            public void BFSWalkWithStartNode(int vertex)
            {
                var visited = new HashSet<int>();
                // Mark this node as visited
                visited.Add(vertex);
                // Queue for BFS
                var queue = new Queue<int>();
                // Add this node to the queue
                queue.Enqueue(vertex);

                while (queue.Count > 0)
                {
                    var current = queue.Dequeue();
                    Console.WriteLine(current);
                    // Only if the node has a any adj notes
                    if (Adj.ContainsKey(current))
                    {
                        // Iterate through UNVISITED nodes
                        foreach (int neighbour in Adj[current].Where(a => !visited.Contains(a)))
                        {
                            visited.Add(neighbour);
                            queue.Enqueue(neighbour);
                        }
                    }
                }
            }

            public int BFSFindNodeWithStartNode(int vertex, int lookingFor)
            {
                if (vertex == lookingFor)
                {
                    Console.WriteLine("Found it!");
                    Console.WriteLine("Steps Took: 0");
                    return 0;
                }
                var visited = new HashSet<int>();
                // Mark this node as visited
                visited.Add(vertex);
                // Queue for BFS
                var queue = new Queue<int>();
                // Add this node to the queue
                queue.Enqueue(vertex);

                int count = 0;

                while (queue.Count > 0)
                {
                    var current = queue.Dequeue();
                    Console.WriteLine(current);
                    if (current == lookingFor)
                    {
                        Console.WriteLine("Found it!");
                        Console.WriteLine("Steps Took: " + count);
                        return visited.Count();
                    }

                    // Only if the node has a any adj nodes
                    if (Adj.ContainsKey(current))
                    {
                        // Iterate through UNVISITED nodes
                        foreach (int neighbour in Adj[current].Where(a => !visited.Contains(a)))
                        {
                            visited.Add(neighbour);
                            queue.Enqueue(neighbour);
                        }
                    }
                    count++;
                }
                Console.WriteLine("Could not find node!");
                return count;
            }

            public void DFSWalkWithStartNode(int vertex)
            {
                var visited = new HashSet<int>();
                // Mark this node as visited
                visited.Add(vertex);
                // Stack for DFS
                var stack = new Stack<int>();
                // Add this node to the stack
                stack.Push(vertex);

                while (stack.Count > 0)
                {
                    var current = stack.Pop();
                    Console.WriteLine(current);
                    // ADD TO VISITED HERE
                    if (!visited.Contains(current))
                    {
                        visited.Add(current);
                    }
                    // Only if the node has a any adj nodes
                    if (Adj.ContainsKey(current))
                    {
                        // Iterate through UNVISITED nodes
                        foreach (var neighbour in Adj[current].Where(a => !visited.Contains(a)))
                        {
                            visited.Add(neighbour);
                            stack.Push(neighbour);
                        }
                    }
                }
            }

            public void DFSWithRecursion(int vertex)
            {
                var visited = new HashSet<int>();
                Traverse(vertex, visited);
            }

            private void Traverse(int v, HashSet<int> visited)
            {
                // Mark this node as visited
                visited.Add(v);
                Console.WriteLine(v);
                // Only if the node has a any adjacent nodes.
                if (Adj.ContainsKey(v))
                {
                    // Iterate through UNVISITED nodes
                    foreach (int neighbour in Adj[v].Where(a => !visited.Contains(a)))
                    {
                        Traverse(neighbour, visited);
                    }
                }
            }
        }
    }
}
