// See https://aka.ms/new-console-template for more information

using _4_SimpleManualStack;

SimpleManualStack simpleManualStack = new();

Console.WriteLine(simpleManualStack.IsEmpty());
Console.WriteLine(simpleManualStack.Peek());

simpleManualStack.Push(74.504);
simpleManualStack.Push(1.73);

Console.WriteLine(simpleManualStack.IsEmpty());
Console.WriteLine(simpleManualStack.Peek());

Console.WriteLine(simpleManualStack.Pop());

Console.WriteLine(simpleManualStack.IsEmpty());
Console.WriteLine(simpleManualStack.Peek());

Console.ReadLine();