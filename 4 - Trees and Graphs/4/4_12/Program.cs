using Common;

BinaryTree<int> bt = new();

BinaryTreeNode<int> n1 = new(1);
BinaryTreeNode<int> n1_2 = new(2);
BinaryTreeNode<int> n1_5 = new(5);

bt.Root = n1;

n1.Left = n1_2;
n1.Right = n1_5;

BinaryTreeNode<int> n2_7 = new(7);
BinaryTreeNode<int> n2_8 = new(8);

n1_2.Left = n2_7;
n1_2.Right = n2_8;

BinaryTreeNode<int> n7_11 = new(11);
BinaryTreeNode<int> n7_3 = new(3);

n2_7.Left = n7_11;
n2_7.Right = n7_3;

BinaryTreeNode<int> n8_1 = new(1);
BinaryTreeNode<int> n8_2 = new(2);

n2_8.Left = n8_1;
n2_8.Right = n8_2;

BinaryTreeNode<int> n1_1_1 = new(1);
BinaryTreeNode<int> n1_1_2 = new(1);

n8_1.Left = n1_1_1;
n8_1.Right = n1_1_2;

BinaryTreeNode<int> n1_1_3 = new(1);
BinaryTreeNode<int> n1_1_4 = new(1);

n1_1_1.Left = n1_1_3;
n1_1_1.Right = n1_1_4;

BinaryTreeNode<int> n1_1_5 = new(1);
BinaryTreeNode<int> n1_1_6 = new(1);

n1_1_4.Left = n1_1_5;
n1_1_4.Right = n1_1_6;

BinaryTreeNode<int> n5_9 = new(9);
BinaryTreeNode<int> n5_2 = new(2);

n1_5.Left = n5_9;
n1_5.Right = n5_2;

Console.WriteLine(bt.PathSum(n1, 3)); // 6
bt.ClearVisitedNodes(bt.Root);

Console.WriteLine(bt.PathSum(n1, 2)); // 9
bt.ClearVisitedNodes(bt.Root);

Console.WriteLine(bt.PathSum(n1, 9)); // 3