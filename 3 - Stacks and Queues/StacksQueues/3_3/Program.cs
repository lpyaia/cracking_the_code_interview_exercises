using _3_3;

var setOfStacks = new SetOfStacks<int>(2);

setOfStacks.Push(1);
setOfStacks.Push(2);
setOfStacks.Push(3);
setOfStacks.Push(4);
setOfStacks.Push(5);
setOfStacks.Push(6);
setOfStacks.Push(7);

Console.WriteLine(setOfStacks.Pop());
setOfStacks.Push(7);

Console.WriteLine(setOfStacks.Pop());
Console.WriteLine(setOfStacks.Pop());
setOfStacks.Push(6);

Console.WriteLine(setOfStacks.Pop());
Console.WriteLine(setOfStacks.Pop());
Console.WriteLine(setOfStacks.Pop());
Console.WriteLine(setOfStacks.Pop());
Console.WriteLine(setOfStacks.Pop());
Console.WriteLine(setOfStacks.Pop());

setOfStacks.Push(1);
setOfStacks.Push(2);
setOfStacks.Push(3);

Console.WriteLine(setOfStacks.PopAt(0));
Console.WriteLine(setOfStacks.PopAt(1));