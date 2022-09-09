using Common;

var binaryTree = new BinaryTree<int>();
var node1 = new BinaryTreeNode<int>(1);
var node2 = new BinaryTreeNode<int>(1);
var node3 = new BinaryTreeNode<int>(1);
var node4 = new BinaryTreeNode<int>(1);
var node5 = new BinaryTreeNode<int>(1);
var node6 = new BinaryTreeNode<int>(1);
var node7 = new BinaryTreeNode<int>(1);

node1.Left = node2;
node1.Right = node3;

node2.Left = node4;
node2.Right = node5;

node4.Left = node6;
node4.Right = node7;

binaryTree.Root = node1;

Console.WriteLine(binaryTree.IsBalanced()); // FALSE

var node8 = new BinaryTreeNode<int>(1);

node6.Left = node8;

Console.WriteLine(binaryTree.IsBalanced()); // FALSE

var node9 = new BinaryTreeNode<int>(1);
var node10 = new BinaryTreeNode<int>(1);
var node11 = new BinaryTreeNode<int>(1);
var node12 = new BinaryTreeNode<int>(1);

node5.Left = node9;
node5.Right = node10;

node3.Left = node11;
node3.Right = node12;

Console.WriteLine(binaryTree.IsBalanced()); // FALSE

var node13 = new BinaryTreeNode<int>(1);

node12.Left = node13;

Console.WriteLine(binaryTree.IsBalanced()); // TRUE