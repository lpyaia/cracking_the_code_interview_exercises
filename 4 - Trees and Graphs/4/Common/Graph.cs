namespace Common
{
    public class Graph<T>
    {
        public GraphNode<T>? Root { get; set; }

        public List<GraphNode<T>> Nodes { get; set; }

        public Graph(GraphNode<T> root)
        {
            Root = root;
            Nodes = new List<GraphNode<T>>();
        }

        public Graph()
        {
            Nodes = new List<GraphNode<T>>();
        }

        public void AddNode(T value)
        {
            Nodes.Add(new GraphNode<T>(value));
        }

        public GraphNode<T> GetNode(T value)
        {
            return Nodes.First(g => g.Value.Equals(value));
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

        public string BuildOrder()
        {
            bool changed = true;
            string output = "";

            while (Nodes.Any(n => !n.Visited) && changed)
            {
                changed = false;

                foreach (var node in from node in Nodes.Where(n => !n.Visited)
                                     where node.Neighbors.All(n => n.Visited) || node.Neighbors.Count == 0
                                     select node)
                {
                    node.Visited = true;
                    changed = true;
                    output += $"{node.Value},";
                }
            }

            output = Nodes.All(n => n.Visited) ? output : "ERROR";

            return output;
        }

        public bool CheckSubtree(GraphNode<int>? rootT1, GraphNode<int>? rootT2)
        {
            var tempRootT1 = rootT1;
            var tempRootT2 = rootT2;

            if (tempRootT1 == null || tempRootT2 == null) return false;

            IEnumerable<GraphNode<int>> nodesFound = FindNodesByValue(tempRootT1, tempRootT2.Value);

            bool areEquals = false;

            foreach (var nodeFound in nodesFound)
            {
                areEquals |= CheckIfTreesAreEqual(nodeFound, tempRootT2);
            }

            return areEquals;
        }

        private bool CheckIfTreesAreEqual(GraphNode<int> node1, GraphNode<int> node2)
        {
            if (node1.Neighbors.Count != node2.Neighbors.Count ||
               node1.Value != node2.Value)
            {
                return false;
            }

            bool areEquals = true;

            for (int index = 0; index < node1.Neighbors.Count; index++)
            {
                areEquals &= CheckIfTreesAreEqual(node1.Neighbors[index], node2.Neighbors[index]);

                if (!areEquals) break;
            }

            return areEquals;
        }

        private IEnumerable<GraphNode<int>> FindNodesByValue(GraphNode<int>? node, int value)
        {
            if (node == null) return Enumerable.Empty<GraphNode<int>>();

            var listNodes = new List<GraphNode<int>>();

            node.Neighbors.ForEach(n =>
            {
                if (n.Value == value)
                    listNodes.Add(n);

                listNodes.AddRange(FindNodesByValue(n, value));
            });

            return listNodes;
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