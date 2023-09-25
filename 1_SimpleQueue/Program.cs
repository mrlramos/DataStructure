// See https://aka.ms/new-console-template for more information

using _1_SimpleQueue;

SimpleQueue simpleQueue = new();

Console.WriteLine(simpleQueue.ListCount());

simpleQueue.Insert("Marlon");
simpleQueue.Insert("Pedro");

Console.WriteLine(simpleQueue.ToString());
Console.WriteLine(simpleQueue.ListCount());

simpleQueue.Remove();
Console.WriteLine(simpleQueue.ToString());
Console.WriteLine(simpleQueue.ListCount());


Console.ReadLine();