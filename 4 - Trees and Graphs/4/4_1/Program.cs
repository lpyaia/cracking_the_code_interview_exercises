using Common;

var n1 = new GraphNode<int>(1);
var n2 = new GraphNode<int>(2);
var n3 = new GraphNode<int>(3);
var n4 = new GraphNode<int>(4);
var n5 = new GraphNode<int>(5);

var graph = new Graph<int>(n1);

n1.AddNeighbor(n2);
n2.AddNeighbor(n3);
n3.AddNeighbor(n4);
n4.AddNeighbor(n5);
n2.AddNeighbor(n1);

Console.WriteLine(graph.HasRoute(n4, n1));