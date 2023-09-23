// See https://aka.ms/new-console-template for more information

string[] queue = Array.Empty<string>();
short count = 0;

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
    Array.Resize(ref queue, ++count);
    queue[count - 1] = person;
}

void Remove()
{
    if (count == 0)
    {
        throw new InvalidOperationException($"Queue empty");
    }

    string elementRemoved = queue[0];

    if (count > 1)
    {
        for (short i = 0; i < count; i++)
        {
            queue[i] = queue[i + 1];
        }
    }  

    Array.Resize(ref queue, --count);
    Console.WriteLine($"Element removed {elementRemoved}");
}

void ListAll()
{
    if (queue.Length > 0)
    {
        for (short i = 0; i < queue.Length; i++)
        {
            Console.WriteLine(queue[i]);
        }
    }
    else
    {
        Console.WriteLine("Queue empty");
    }
}

void ListCount()
{
    Console.WriteLine(queue.Length);
}