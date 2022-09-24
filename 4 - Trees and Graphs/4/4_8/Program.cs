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

node20.Parent = null;
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

Console.WriteLine(bst.FirstCommonAncester(node12, node22)?.Value); // 20
Console.WriteLine(bst.FirstCommonAncester(node10, node4)?.Value); // 8
Console.WriteLine(bst.FirstCommonAncester(node10, node22)?.Value); // 20
Console.WriteLine(bst.FirstCommonAncester(node10, node12)?.Value); // 8
Console.WriteLine(bst.FirstCommonAncester(node10, node14)?.Value); // 12