using Common;

var binaryTree = new BinaryTree<int>();
var node8 = new BinaryTreeNode<int>(8);
var node3 = new BinaryTreeNode<int>(3);
var node10 = new BinaryTreeNode<int>(10);
var node2 = new BinaryTreeNode<int>(2);
var node6 = new BinaryTreeNode<int>(6);
var node9 = new BinaryTreeNode<int>(9);
var node15 = new BinaryTreeNode<int>(15);
var node15_1 = new BinaryTreeNode<int>(15);
var node20 = new BinaryTreeNode<int>(20);

node8.Left = node3;
node8.Right = node10;

node3.Left = node2;
node3.Right = node6;

node10.Left = node9;
node10.Right = node15;

node15.Left = node15_1;
node15.Right = node20;

binaryTree.Root = node8;

Console.WriteLine(binaryTree.IsBst(node8)); // TRUE

var node7 = new BinaryTreeNode<int>(7);

node20.Left = node7;

Console.WriteLine(binaryTree.IsBst(node8)); // FALSE