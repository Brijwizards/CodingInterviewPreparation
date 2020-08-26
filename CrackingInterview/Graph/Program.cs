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
            // Create a graph given in the above diagram
            var graph = new Graph();

            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(1, 2);

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
                    var hashSet = new HashSet<int>();
                    hashSet.Add(target);
                    Adj.Add(source, hashSet);
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
                // Only if the node has a any adj notes
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
