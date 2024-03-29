﻿using _3_1;

var stack = new TripleStack<int?>(10);

stack.Push(1, 0);
stack.Push(2, 0);

stack.Push(10, 1);
stack.Push(20, 1);
stack.Push(30, 1);

stack.Push(100, 2);
stack.Push(200, 2);
stack.Push(300, 2);
stack.Push(400, 2);

stack.Pop(2);
stack.Pop(2);
stack.Pop(2);
stack.Pop(2);

stack.Push(100, 2);

Console.WriteLine(stack.Peek(2));