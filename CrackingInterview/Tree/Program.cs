using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tree
            BinaryTree tree = new BinaryTree();
            //Node node = new Node(6);
            //node.left = new Node(3);
            //node.left.left = new Node(2);
            //node.left.right = new Node(5);
            //node.left.right.right = new Node(4);
            //node.left.right.left = new Node(7);
            //node.right = new Node(5);
            //node.right.right = new Node(4);

            Node node = new Node(5);
            node.left = new Node(4);
            node.left.left = new Node(11);
            node.left.left.left = new Node(7);
            node.left.left.right = new Node(2);

            node.right = new Node(8);
            node.right.left = new Node(13);
            node.right.right = new Node(4);
            node.right.right.left = new Node(5);
            node.right.right.right = new Node(1);
            //tree.PathSum(node, 22);

            var list = tree.ZigzagLevelOrder(node);
            Node ancestor = tree.LowestCommonAncestor(node, new Node(2), new Node(5));
            //int sum = tree.TreePathSum(node);
            //bool isTrue = tree.TreePathSum(node,653);
            bool isTrue = tree.IsBST(node);
            int height = tree.TreeHeight(node);
            tree.PrintTreePreOrder(node);
            tree.PrintTreePreOrderIterative(node);
            string serializedTree = tree.Serialize(node);
            tree.Deserialize(serializedTree);
            tree.PrintTreePreOrder(tree.Deserialize(serializedTree));
            //string serializedTree = tree.Serialize(node, string.Empty);
            #endregion
        }
    }

    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }

    public class BinaryTree
    {
        public int globalCount;
        public BinaryTree()
        {
            globalCount = 0;
        }
        // Returns sum of all root to leaf paths.  
        // The first parameter is root of current  
        // subtree, the second parameter is value  
        // of the number formed by nodes from root 
        // to this node  
        public int TreePathsSumUtil(Node node, int sumSoFar)
        {
            // Base case  
            if (node == null)
            {
                return 0;
            }

            // Update val  
            int currentSum = (sumSoFar * 10 + node.data);

            // if current node is leaf, return  
            // the current value of val  
            if (node.left == null && node.right == null)
            {
                return currentSum;
            }

            // recur sum of values for left and right subtree  
            return TreePathsSumUtil(node.left, currentSum) +
                TreePathsSumUtil(node.right, currentSum);
        }

        public IList<IList<int>> ZigzagLevelOrder(Node root)
        {
            var list = new List<IList<int>>();
            if (root == null) return list;

            var q = new Queue<Node>();
            q.Enqueue(root);
            var level = 0;
            while (q.Count > 0)
            {
                var count = q.Count;
                var l = new List<int>();
                for (var i = 0; i < count; i++)
                {
                    var node = q.Dequeue();
                    if (level % 2 == 0)
                    {
                        l.Add(node.data);
                    }
                    else
                    {
                        l.Insert(0, node.data);
                    }
                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }
                level++;
                list.Add(l);
            }

            return list;
        }

        public int TreePathSum(Node node)
        {
            return TreePathsSumUtil(node, 0);

        }

        public bool TreePathSum(Node node, int val)
        {
            return PathExist(node, val, 0);

        }
        public bool PathExist(Node node, int val, int sumSoFar)
        {
            if (node == null) return false;
            int currentSum = sumSoFar * 10 + node.data;
            if (currentSum == val && node.left == null && node.right == null) return true;
            return PathExist(node.left, val, currentSum) || PathExist(node.right, val, currentSum);
        }

        public bool IsBST(Node node)
        {
            return CheckBST(node, null, null);
        }

        public bool CheckBST(Node node, Node leftTree, Node rightTree)
        {
            globalCount++;
            if (node == null)
            {
                return true;
            }

            if (leftTree != null && node.data == leftTree.data || rightTree != null && node.data == rightTree.data)
            {
                return false;
            }
            if (leftTree != null && node.data < leftTree.data)
            {
                return false;
            }
            if (rightTree != null && node.data > rightTree.data)
            {
                return false;
            }
            return CheckBST(node.left, leftTree, node) && CheckBST(node.right, node, rightTree);
        }
        public void PrintTreePreOrder(Node root)
        {
            //globalCount++;
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.data);
            PrintTreePreOrder(root.left);
            PrintTreePreOrder(root.right);
        }

        public int TreeHeight(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftHeight = TreeHeight(root.left);
            int rightHeight = TreeHeight(root.right);
            if (leftHeight > rightHeight)
            {
                return leftHeight + 1;
            }
            return rightHeight + 1;
        }

        public void PrintTreePreOrderIterative(Node root)
        {
            if (root == null)
            {
                return;
            }
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count() != 0)
            {
                Node current = stack.Pop();
                Console.WriteLine(current.data);
                if (current.right != null)
                {
                    stack.Push(current.right);
                }
                if (current.left != null)
                {
                    stack.Push(current.left);
                }
            }
        }

        // Serialization: Encodes a tree to a single string.
        public string Serialize(Node root)
        {
            if (root == null)
            {
                return null;
            }
            return (root.data + " " + Serialize(root.left) + Serialize(root.right));
        }

        // Deserialization: // Decodes your encoded data to tree.
        private Node Deserialize(Queue<string> data)
        {
            if (data.Count() == 0)
            {
                return null; ;
            }
            var val = data.Dequeue();
            if (val == null) return null;
            var newTree = new Node(Convert.ToInt32(val));
            newTree.left = Deserialize(data);
            newTree.right = Deserialize(data);
            return newTree;
        }

        // Decodes your encoded data to tree.
        public Node Deserialize(string data)
        {
            var q = new Queue<string>();
            foreach (var v in data.Trim().Split(' ')) q.Enqueue(v);
            return Deserialize(q);
        }

        public Node LowestCommonAncestor(Node root, Node p, Node q)
        {
            if (root == q || root == p || root == null) return root;

            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);

            if (left != null && right != null) return root;
            else if (left == null) return right;
            else return left;
        }

        public IList<IList<int>> LevelOrderBottom(Node root)
        {
            var list = new List<IList<int>>();
            if (root == null)
            {
                return list;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            var tempList = new List<int>();
            while (queue.Count != 0)
            {
                Node current = queue.Dequeue();
                tempList.Add(current.data);
                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }
                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }
            list.Add(tempList);
            list.Reverse();
            return list;
        }

        public IList<IList<int>> PathSum(Node root, int sum)
        {
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> currentPath = new List<int>();
            GetPaths(root, sum, result, currentPath);
            return result;
        }

        private void GetPaths(Node root, int sum, IList<IList<int>> result, IList<int> currentPath)
        {
            if (root == null)
                return;
            currentPath.Add(root.data);
            if (root.data == sum && root.left == null && root.right == null)
            {
                result.Add(new List<int>(currentPath));
            }

            GetPaths(root.left, sum - root.data, result, currentPath);
            GetPaths(root.right, sum - root.data, result, currentPath);
            currentPath.RemoveAt(currentPath.Count - 1);

        }

        public Node SubtreeWithAllDeepest(Node root)
        {
            if (root == null)
            {
                return root;
            }

            (int depth, Node deepest) = GetDeepest(root, 0);
            return deepest;
        }

        public static (int depth, Node deeepest) GetDeepest(Node node, int currentDepth)
        {
            if (node == null)
            {
                return (currentDepth, node);
            }

            var left = GetDeepest(node.left, 1 + currentDepth);
            var right = GetDeepest(node.right, 1 + currentDepth);

            if (left.depth == right.depth)
            {
                return (left.depth, node);
            }

            else
            {
                return left.depth > right.depth ? left : right;
            }
        }
    }
}
