namespace Common
{
    public class Graph<T>
    {
        public GraphNode<T> Root { get; set; }

        public Graph(GraphNode<T> root)
        {
            Root = root;
        }

        public void DepthFirstSearch(GraphNode<T> node)
        {
            Visit(node);

            foreach (var child in node.Children)
            {
                if (!node.Visited)
                {
                    DepthFirstSearch(child);
                }
            }
        }

        public void BreadthFirstSearch(GraphNode<T> node)
        {
            var queue = new Queue<GraphNode<T>>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();

                Visit(currentNode);

                foreach (var child in currentNode.Children)
                {
                    if (!child.Visited)
                    {
                        queue.Enqueue(child);
                    }
                }
            }
        }

        public void Visit(GraphNode<T> node)
        {
            node.Visited = true;
            Console.WriteLine($"{node.Value}, ");
        }
    }

    public class GraphNode<T>
    {
        public List<GraphNode<T>> Children { get; set; }

        public bool Visited { get; set; }

        public T Value { get; set; }

        public GraphNode(T value)
        {
            Value = value;
            Children = new List<GraphNode<T>>();
        }
    }
}