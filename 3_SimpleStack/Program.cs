// See https://aka.ms/new-console-template for more information

using _3_SimpleStack;

SimpleStack simpleStack = new();

Console.WriteLine(simpleStack.IsEmpty());
Console.WriteLine(simpleStack.Peek());

simpleStack.Push(74.504);
simpleStack.Push(1.73);

Console.WriteLine(simpleStack.IsEmpty());
Console.WriteLine(simpleStack.Peek());

simpleStack.Pop();

Console.WriteLine(simpleStack.IsEmpty());
Console.WriteLine(simpleStack.Peek());

Console.ReadLine();