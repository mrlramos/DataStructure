namespace _3_SimpleStack
{
    internal class SimpleStack
    {
        readonly Stack<double> stack = new();

        internal void Push(double number)
        {
            stack.Push(number);
        }

        internal void Pop()
        {
            stack.Pop();
        }

        internal double? Peek()
        {
            if (stack.Count > 0)
            {
                return stack.First();
            }
            else
            {
                return null;
            }
        }

        internal bool IsEmpty()
        {
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}