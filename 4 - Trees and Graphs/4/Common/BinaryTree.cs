namespace Common
{
    public class BinaryTree<T> where T : struct
    {
        public BinaryTreeNode<T>? Root { get; set; }

        public BinaryTree(T rootValue)
        {
            Root = new BinaryTreeNode<T>(rootValue);
        }

        public BinaryTree()
        {
        }

        // In-order traversal means to "visit" (often, print) the left branch, then the current node, and finally, the right branch.
        // When performed on a binary search tree, it visits the nodes in ascending order (hence the name "in-order").
        public void InOrder(BinaryTreeNode<T>? node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Visit(node);
                InOrder(node.Right);
            }
        }

        // Pre-order traversal visits the current node before its child nodes (hence the name "pre-order").
        // In a pre-order traversal, the root is always the first node visited.
        public void PreOrder(BinaryTreeNode<T>? node)
        {
            if (node != null)
            {
                Visit(node);
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        // Post-order traversal visits the current node after its child nodes (hence the name "post-order")
        // In a post-order traversal, the root is always the last node visited.
        public void PostOrder(BinaryTreeNode<T>? node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Visit(node);
            }
        }

        public void Visit(BinaryTreeNode<T> node)
        {
            Console.WriteLine($"{node.Value}, ");
        }

        public void Trie()
        {
        }

        public List<List<BinaryTreeNode<T>>> ListOfDepths()
        {
            var listOfDepths = new List<List<BinaryTreeNode<T>>>();

            if (Root == null)
                return listOfDepths;

            var queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();

                bool hasListOfCurrentDepth = currentNode.Depth <= listOfDepths.Count - 1;

                if (!hasListOfCurrentDepth)
                {
                    listOfDepths.Add(new List<BinaryTreeNode<T>>());
                }

                listOfDepths[currentNode.Depth].Add(currentNode);

                if (currentNode.Left != null)
                {
                    currentNode.Left.Depth = currentNode.Depth + 1;
                    queue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    currentNode.Right.Depth = currentNode.Depth + 1;
                    queue.Enqueue(currentNode.Right);
                }
            }

            return listOfDepths;
        }

        public bool IsBalanced()
        {
            return IsBalanced(Root) != -1;
        }

        private int IsBalanced(BinaryTreeNode<T>? node)
        {
            if (node != null)
            {
                int heightLeft = IsBalanced(node.Left);
                if (heightLeft == int.MinValue) return int.MinValue;

                int heightRight = IsBalanced(node.Right);
                if (heightRight == int.MinValue) return int.MinValue;

                if (Math.Abs(heightLeft - heightRight) > 1)
                {
                    return int.MinValue;
                }

                return Math.Max(heightLeft + 1, heightRight + 1);
            }

            return 0;
        }

        public bool IsBst(BinaryTreeNode<int>? root)
        {
            return CheckBst(root) != null;
        }

        private List<int>? CheckBst(BinaryTreeNode<int>? node)
        {
            if (node != null)
            {
                var children = new List<int>();

                children.Add(node.Value);

                var leftNodes = CheckBst(node.Left);
                if (leftNodes == null || leftNodes.Any(v => node.Value < v))
                    return null;

                var rightNodes = CheckBst(node.Right);
                if (rightNodes == null || rightNodes.Any(v => node.Value > v))
                    return null;

                children.AddRange(leftNodes);
                children.AddRange(rightNodes);

                return children;
            }

            return new List<int>();
        }

        public int? NextBstSuccessor(BinaryTreeNode<int>? node)
        {
            if (node == null) return null;

            if (node.Right != null)
            {
                return GetMostLeftChild(node.Right);
            }

            else
            {
                BinaryTreeNode<int>? q = node;
                BinaryTreeNode<int>? x = q.Parent;

                while (x != null && x.Left != q)
                {
                    q = x;
                    x = x.Parent;
                }

                return x?.Value;
            }
        }

        public int? GetMostLeftChild(BinaryTreeNode<int>? node)
        {
            if (node == null) return null;

            if (node.Left == null) return node.Value;

            return GetMostLeftChild(node.Left);
        }

        public BinaryTreeNode<T>? FirstCommonAncester(BinaryTreeNode<T>? node1, BinaryTreeNode<T>? node2)
        {
            if (node1 == null || node2 == null) return null;

            while (node1.Parent != null)
            {
                node1 = node1.Parent;
                node1.IsVisited = true;
            }

            node2 = node2.Parent;

            while (node2 != null && node2.Parent != null && !node2.IsVisited)
            {
                node2 = node2.Parent;
            }

            return node2;
        }

        public int PathSum(BinaryTreeNode<int> node, int value)
        {
            int paths = 0;
            var queue = new Queue<BinaryTreeNode<int>>();

            queue.Enqueue(node);

            node.IsVisited = true;

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();

                paths += PathSum(currentNode, value, 0, queue);
            }

            return paths;
        }

        private int PathSum(BinaryTreeNode<int>? node, int value, int currentSum, Queue<BinaryTreeNode<int>> queue)
        {
            if (node == null)
                return 0;

            if (!node.IsVisited)
            {
                queue.Enqueue(node);
                node.IsVisited = true;
            }

            int sum = currentSum + node.Value;

            if (sum == value)
                return 1;

            int paths = 0;

            paths += PathSum(node.Left, value, sum, queue);
            paths += PathSum(node.Right, value, sum, queue);

            return paths;
        }

        public void ClearVisitedNodes(BinaryTreeNode<T>? node)
        {
            if (node == null)
                return;

            ClearVisitedNodes(node.Left);
            node.IsVisited = false;
            ClearVisitedNodes(node.Right);
        }
    }

    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode<T>? Right { get; set; }

        public BinaryTreeNode<T>? Left { get; set; }

        public BinaryTreeNode<T>? Parent { get; set; }

        public int Depth { get; set; }

        public T Value { get; set; }

        public bool IsVisited { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
            Depth = 0;
        }
    }
}