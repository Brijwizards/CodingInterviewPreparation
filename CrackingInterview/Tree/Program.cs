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

            TreeNode node = new TreeNode(4);
            node.left = new TreeNode(1);
            node.left.left = new TreeNode(0);
            node.left.right = new TreeNode(2);
            node.left.right.right = new TreeNode(3);

            node.right = new TreeNode(6);
            node.right.left = new TreeNode(5);
            node.right.right = new TreeNode(7);
            node.right.right.right = new TreeNode(8);
            //node.right.right.right = new TreeNode(1);

            BinaryTree tree = new BinaryTree();
            #region Tree
            TreeNode inserBst = new TreeNode(4);
            inserBst.left = new  TreeNode(2);
            inserBst.right = new TreeNode(7);
            inserBst.left.left = new TreeNode(1);
            inserBst.left.right = new TreeNode(3);
            tree.InsertIntoBST(inserBst, 5);
            tree.PrintTreelevelOrderRecursion(node);
            tree.PrintTreeLevelOrder(node);
            tree.BstToGst(node);
            tree.PrintTreeLevelOrder(tree.BstToGst(node));
            #region BST to Greater Tree

            #endregion
            //Node node = new Node(6);
            //node.left = new Node(3);
            //node.left.left = new Node(2);
            //node.left.right = new Node(5);
            //node.left.right.right = new Node(4);
            //node.left.right.left = new Node(7);
            //node.right = new Node(5);
            //node.right.right = new Node(4);

            //TreeNode node = new TreeNode(5);
            //node.left = new TreeNode(4);
            //node.left.left = new TreeNode(11);
            //node.left.left.left = new TreeNode(7);
            //node.left.left.right = new TreeNode(2);

            //node.right = new TreeNode(8);
            //node.right.left = new TreeNode(13);
            //node.right.right = new TreeNode(4);
            //node.right.right.left = new TreeNode(5);
            //node.right.right.right = new TreeNode(1);
            //tree.PathSum(node, 22);

            //var list = tree.ZigzagLevelOrder(node);
            //Node ancestor = tree.LowestCommonAncestor(node, new Node(2), new Node(5));
            //int sum = tree.TreePathSum(node);
            //bool isTrue = tree.TreePathSum(node,653);
            //bool isTrue = tree.IsBST(node);
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

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int data)
        {
            this.val = data;
            left = null;
            right = null;
        }
    }

    public class BinaryTree
    {
        public static int sum = 0;
        public TreeNode BstToGst(TreeNode root)
        {
            if (root == null)
                return root;
            // Reverse of In order.
            BstToGst(root.right);
            sum = sum + root.val;
            root.val = sum;
            //Console.WriteLine(sum);
            BstToGst(root.left);

            return root;
        }
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
        public int TreePathsSumUtil(TreeNode node, int sumSoFar)
        {
            // Base case  
            if (node == null)
            {
                return 0;
            }

            // Update val  
            int currentSum = (sumSoFar * 10 + node.val);

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

        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null) return new TreeNode(val);

            // insert into the right subtree
            if (val > root.val) root.right = InsertIntoBST(root.right, val);
            // insert into the left subtree
            else root.left = InsertIntoBST(root.left, val);

            return root;
        }

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var list = new List<IList<int>>();
            if (root == null) return list;

            var q = new Queue<TreeNode>();
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
                        l.Add(node.val);
                    }
                    else
                    {
                        l.Insert(0, node.val);
                    }
                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }
                level++;
                list.Add(l);
            }

            return list;
        }
        public int TreePathSum(TreeNode node)
        {
            return TreePathsSumUtil(node, 0);

        }
        public bool TreePathSum(TreeNode node, int val)
        {
            return PathExist(node, val, 0);

        }
        public bool PathExist(TreeNode node, int val, int sumSoFar)
        {
            if (node == null) return false;
            int currentSum = sumSoFar * 10 + node.val;
            if (currentSum == val && node.left == null && node.right == null) return true;
            return PathExist(node.left, val, currentSum) || PathExist(node.right, val, currentSum);
        }
        public bool IsBST(TreeNode node)
        {
            return CheckBST(node, null, null);
        }
        public bool CheckBST(TreeNode node, TreeNode leftTree, TreeNode rightTree)
        {
            globalCount++;
            if (node == null)
            {
                return true;
            }

            if (leftTree != null && node.val == leftTree.val || rightTree != null && node.val == rightTree.val)
            {
                return false;
            }
            if (leftTree != null && node.val < leftTree.val)
            {
                return false;
            }
            if (rightTree != null && node.val > rightTree.val)
            {
                return false;
            }
            return CheckBST(node.left, leftTree, node) && CheckBST(node.right, node, rightTree);
        }
        public void PrintTreePreOrder(TreeNode root)
        {
            //globalCount++;
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.val);
            PrintTreePreOrder(root.left);
            PrintTreePreOrder(root.right);
        }
        public void PrintTreeInOrder(TreeNode root)
        {
            //globalCount++;
            if (root == null)
            {
                return;
            }
           
            PrintTreePreOrder(root.left);
            Console.WriteLine(root.val);
            PrintTreePreOrder(root.right);
        }

        public void PrintTreeLevelOrder(TreeNode root)
        {
            //globalCount++;
            if (root == null)
            {
                return;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count > 0)
            {
                var dequeuedNode = queue.Dequeue();
                Console.WriteLine(dequeuedNode.val);

                if (dequeuedNode.left != null)
                {
                    queue.Enqueue(dequeuedNode.left);
                }

                if(dequeuedNode.right != null)
                {
                    queue.Enqueue(dequeuedNode.right);
                }
            }
            //PrintTreePreOrder(root.left);
            //Console.WriteLine(root.val);
            //PrintTreePreOrder(root.right);
        }
        public int TreeHeight(TreeNode root)
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
        public void PrintTreePreOrderIterative(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count() != 0)
            {
                TreeNode current = stack.Pop();
                Console.WriteLine(current.val);
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

        public void PrintTreelevelOrderRecursion(TreeNode root)
        {
            int heigth = TreeHeight(root);
            for(int i = 1; i<=heigth; i++)
            {
                PrintTreelevelOrderRecursion(root, i);
            }
        }

        public void PrintTreelevelOrderRecursion(TreeNode root, int level)
        {
            if (root == null)
                return;
            if(level == 1)
            {
                Console.WriteLine(root.val);
            }
            else if(level > 1)
            {
                PrintTreelevelOrderRecursion(root.left, level - 1);
                PrintTreelevelOrderRecursion(root.right, level - 1);
            }
        }

        // Serialization: Encodes a tree to a single string.
        public string Serialize(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            return (root.val + " " + Serialize(root.left) + Serialize(root.right));
        }
        // Deserialization: // Decodes your encoded data to tree.
        private TreeNode Deserialize(Queue<string> data)
        {
            if (data.Count() == 0)
            {
                return null; ;
            }
            var val = data.Dequeue();
            if (val == null) return null;
            var newTree = new TreeNode(Convert.ToInt32(val));
            newTree.left = Deserialize(data);
            newTree.right = Deserialize(data);
            return newTree;
        }
        // Decodes your encoded data to tree.
        public TreeNode Deserialize(string data)
        {
            var q = new Queue<string>();
            foreach (var v in data.Trim().Split(' ')) q.Enqueue(v);
            return Deserialize(q);
        }
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == q || root == p || root == null) return root;

            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);

            if (left != null && right != null) return root;
            else if (left == null) return right;
            else return left;
        }
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var list = new List<IList<int>>();
            if (root == null)
            {
                return list;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var tempList = new List<int>();
            while (queue.Count != 0)
            {
                TreeNode current = queue.Dequeue();
                tempList.Add(current.val);
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
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> currentPath = new List<int>();
            GetPaths(root, sum, result, currentPath);
            return result;
        }
        private void GetPaths(TreeNode root, int sum, IList<IList<int>> result, IList<int> currentPath)
        {
            if (root == null)
                return;
            currentPath.Add(root.val);
            if (root.val == sum && root.left == null && root.right == null)
            {
                result.Add(new List<int>(currentPath));
            }

            GetPaths(root.left, sum - root.val, result, currentPath);
            GetPaths(root.right, sum - root.val, result, currentPath);
            currentPath.RemoveAt(currentPath.Count - 1);

        }
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }

            (int depth, TreeNode deepest) = GetDeepest(root, 0);
            return deepest;
        }
        public static (int depth, TreeNode deeepest) GetDeepest(TreeNode node, int currentDepth)
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
