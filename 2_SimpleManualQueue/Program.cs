// See https://aka.ms/new-console-template for more information

using _2_SimpleManualQueue;

SimpleManualQueue simpleManualQueue = new();

Console.WriteLine(simpleManualQueue.ListAll());
Console.WriteLine(simpleManualQueue.ListCount());

simpleManualQueue.Insert("Marlon");
simpleManualQueue.Insert("Dax");
simpleManualQueue.Insert("Lygia");

Console.WriteLine(simpleManualQueue.ListAll());
Console.WriteLine(simpleManualQueue.ListCount());

Console.WriteLine(simpleManualQueue.Remove());

Console.WriteLine(simpleManualQueue.ListAll());
Console.WriteLine(simpleManualQueue.ListCount());

Console.ReadLine();