// See https://aka.ms/new-console-template for more information

Stack<double> stack = new();

IsEmpty();
Peek();

Push(74.504);
Push(1.73);

IsEmpty();
Peek();

Pop();

IsEmpty();
Peek();

Console.ReadLine();

void Push(double number)
{
    stack.Push(number);
}

void Pop()
{
    stack.Pop();
}

void Peek()
{
    if (stack.Count != 0)
    {
        Console.WriteLine($"{stack.First()}");
    }
    else
    {
        Console.WriteLine("Stack empty");
    }
}

void IsEmpty()
{
    if (stack.Count == 0)
    {
        Console.WriteLine($"Stack empty");
    }
    else
    {
        Console.WriteLine("The stack contains data");
    }
}