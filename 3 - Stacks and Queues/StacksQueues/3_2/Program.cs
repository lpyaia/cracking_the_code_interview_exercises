var stack = new Stack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(-1);
stack.Push(0);

Console.WriteLine(stack.Min());