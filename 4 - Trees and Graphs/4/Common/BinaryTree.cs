namespace Common
{
    public class BinaryTree<T>
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
    }

    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode<T>? Right { get; set; }

        public BinaryTreeNode<T>? Left { get; set; }

        public int Depth { get; set; }

        public T Value { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
            Depth = 0;
        }
    }
}