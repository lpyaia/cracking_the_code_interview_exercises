using _3_5;

var stack = new SortedStack();

stack.Push(10);
stack.Push(11);
stack.Push(5);
stack.Push(4);
stack.Push(-1);
stack.Push(7);
stack.Push(8);
stack.Push(2);
stack.Push(3);
stack.Push(7);

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());