using Common;

Graph<int> graphT1 = new();

GraphNode<int> g1 = new(1);
GraphNode<int> g11 = new(11);
GraphNode<int> g10 = new(10);
GraphNode<int> g2 = new(2);
GraphNode<int> g3 = new(3);
GraphNode<int> g7 = new(7);
GraphNode<int> g8 = new(8);
GraphNode<int> g9 = new(9);
GraphNode<int> g3_1 = new(3);
GraphNode<int> g4 = new(4);
GraphNode<int> g5 = new(5);
GraphNode<int> g4_1 = new(4);
GraphNode<int> g5_1 = new(5);
GraphNode<int> g6 = new(6);
GraphNode<int> g6_1 = new(6);
GraphNode<int> g7_1 = new(7);
GraphNode<int> g7_2 = new(7);
GraphNode<int> g8_1 = new(8);

graphT1.Root = g1;

g1.AddNeighbor(g11);
g1.AddNeighbor(g10);
g1.AddNeighbor(g2);

g11.AddNeighbor(g3);
g11.AddNeighbor(g7);
g11.AddNeighbor(g8);

g10.AddNeighbor(g9);

g2.AddNeighbor(g3_1);

g3.AddNeighbor(g4);
g3.AddNeighbor(g5);

g3_1.AddNeighbor(g4_1);
g3_1.AddNeighbor(g5_1);
g3_1.AddNeighbor(g6);

g5.AddNeighbor(g6_1);
g5.AddNeighbor(g7_1);

Graph<int> graphT2 = new();

GraphNode<int> g3_2 = new(3);
GraphNode<int> g4_2 = new(4);
GraphNode<int> g5_2 = new(5);
GraphNode<int> g6_2 = new(6);
GraphNode<int> g7_3 = new(7);
GraphNode<int> g8_2 = new(8);

graphT2.Root = g3_2;

g3_2.AddNeighbor(g4_2);
g3_2.AddNeighbor(g5_2);
g3_2.AddNeighbor(g6_2);

g4_2.AddNeighbor(g7_3);
g4_2.AddNeighbor(g8_2);

Console.WriteLine(graphT1.CheckSubtree(graphT1.Root, graphT2.Root)); // False

g4_1.AddNeighbor(g7_2);
g4_1.AddNeighbor(g8_1);

Console.WriteLine(graphT1.CheckSubtree(graphT1.Root, graphT2.Root)); // True