// See https://aka.ms/new-console-template for more information

double[] stack = Array.Empty<double>();
short count = 0;

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
    Array.Resize(ref stack, ++count);
    stack[count - 1] = number;
}

void Pop()
{
    double elementRemoved = stack[stack.Length - 1];
    Array.Resize(ref stack, --count);
}

void Peek()
{
    if (stack.Length != 0)
    {
        Console.WriteLine($"{stack[stack.Length - 1]}");
    }
    else
    {
        Console.WriteLine("Stack empty");
    }
}

void IsEmpty()
{
    if (stack.Length == 0)
    {
        Console.WriteLine($"Stack empty");
    }
    else
    {
        Console.WriteLine("The stack contains data");
    }
}