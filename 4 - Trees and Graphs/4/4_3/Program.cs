using Common;

var binaryTree = new BinaryTree<int>();

var node1 = new BinaryTreeNode<int>(1);
var node2 = new BinaryTreeNode<int>(2);
var node3 = new BinaryTreeNode<int>(3);
var node4 = new BinaryTreeNode<int>(4);
var node5 = new BinaryTreeNode<int>(5);
var node6 = new BinaryTreeNode<int>(6);
var node7 = new BinaryTreeNode<int>(7);
var node8 = new BinaryTreeNode<int>(8);
var node9 = new BinaryTreeNode<int>(9);
var node10 = new BinaryTreeNode<int>(10);
var node11 = new BinaryTreeNode<int>(11);
var node12 = new BinaryTreeNode<int>(12);
var node13 = new BinaryTreeNode<int>(13);
var node14 = new BinaryTreeNode<int>(14);
var node15 = new BinaryTreeNode<int>(15);

binaryTree.Root = node1;

node1.Left = node2;
node1.Right = node3;

node2.Left = node4;
node2.Right = node5;
node3.Left = node6;
node3.Right = node7;

node4.Left = node8;
node4.Right = node9;
node5.Left = node10;
node5.Right = node11;
node6.Left = node12;
node6.Right = node13;
node7.Left = node14;
node7.Right = node15;

int depth = 1;

binaryTree.ListOfDepths().ForEach(listOfDepth =>
{
    Console.WriteLine($"Depth: {depth++}");
    Console.WriteLine(string.Join(",", listOfDepth.Select(node => node.Value)));
});