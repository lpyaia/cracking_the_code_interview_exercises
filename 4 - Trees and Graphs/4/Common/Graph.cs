namespace Common
{
    public class Graph<T>
    {
        public GraphNode<T>? Root { get; set; }

        public Graph(GraphNode<T> root)
        {
            Root = root;
        }

        public Graph()
        {
        }

        public void DepthFirstSearch(GraphNode<T> node)
        {
            Visit(node);

            foreach (var child in node.Neighbors)
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

                foreach (var child in currentNode.Neighbors)
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

        public bool HasRoute(GraphNode<T> start, GraphNode<T> end)
        {
            var queue = new Queue<GraphNode<T>>();

            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                currentNode.Visited = true;

                foreach (var neighbor in currentNode.Neighbors)
                {
                    if (!neighbor.Visited)
                    {
                        if (neighbor == end)
                            return true;

                        queue.Enqueue(neighbor);
                    }
                }
            }

            return false;
        }

        public void CreateBinaryTree(int[] array)
        {
        }
    }

    public class GraphNode<T>
    {
        public List<GraphNode<T>> Neighbors { get; set; }

        public bool Visited { get; set; }

        public T Value { get; set; }

        public GraphNode(T value)
        {
            Value = value;
            Neighbors = new List<GraphNode<T>>();
        }

        public void AddNeighbor(GraphNode<T> node)
        {
            Neighbors.Add(node);
        }
    }
}