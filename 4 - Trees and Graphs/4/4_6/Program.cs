using Common;

var bst = new BinaryTree<int>();

var node20 = new BinaryTreeNode<int>(20);
var node8 = new BinaryTreeNode<int>(8);
var node22 = new BinaryTreeNode<int>(22);
var node4 = new BinaryTreeNode<int>(4);
var node12 = new BinaryTreeNode<int>(12);
var node10 = new BinaryTreeNode<int>(10);
var node14 = new BinaryTreeNode<int>(14);

bst.Root = node20;

node20.Parent = node8;
node20.Left = node8;
node20.Right = node22;

node8.Parent = node20;
node22.Parent = node20;

node8.Left = node4;
node8.Right = node12;

node4.Parent = node8;
node12.Parent = node8;

node12.Left = node10;
node12.Right = node14;

node10.Parent = node12;
node14.Parent = node12;

Console.WriteLine(bst.NextBstSuccessor(node8));

var node18 = new BinaryTreeNode<int>(18);
var node15 = new BinaryTreeNode<int>(15);
var node19 = new BinaryTreeNode<int>(19);
var node16 = new BinaryTreeNode<int>(16);
var node17 = new BinaryTreeNode<int>(17);
var node9 = new BinaryTreeNode<int>(9);

node8.Right = node18;

node18.Parent = node8;

node18.Left = node15;
node18.Right = node19;

node15.Parent = node18;
node19.Parent = node18;

node15.Right = node16;
node15.Left = node12;

node16.Parent = node15;
node12.Parent = node15;

node12.Left = node10;
node12.Right = node14;
node16.Right = node17;

node10.Parent = node12;
node14.Parent = node12;
node17.Parent = node16;

node10.Left = node9;

node9.Parent = node10;

Console.WriteLine(bst.NextBstSuccessor(node8));

node8.Right = null;

Console.WriteLine(bst.NextBstSuccessor(node8));