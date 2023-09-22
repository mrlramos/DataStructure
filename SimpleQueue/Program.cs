// See https://aka.ms/new-console-template for more information

Queue<string> queue = new();

ListAll();
ListCount();

Insert("Marlon");

ListAll();
ListCount();

Remove();

ListAll();
ListCount();

Console.ReadLine();

void Insert(string person)
{
    queue.Enqueue(person);
}

void Remove()
{
    queue.Dequeue();
}

void ListAll()
{
    if (queue.Count > 0)
    {
        foreach (string person in queue)
        {
            Console.WriteLine(person);
        }
    } 
    else
    {
        Console.WriteLine("Queue empty");
    }
}

void ListCount()
{
    Console.WriteLine(queue.Count);
}