namespace _3_SimpleStack
{
    internal class SimpleStack
    {
        readonly Stack<double> stack = new();

        internal void Push(double number)
        {
            stack.Push(number);
        }

        internal bool Pop()
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                return true;
            }
            else
            {
                return false;
            }
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