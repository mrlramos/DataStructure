namespace _4_SimpleManualStack
{
    internal class SimpleManualStack
    {
        double[] stack = Array.Empty<double>();
        short count = 0;

        internal void Push(double number)
        {
            Array.Resize(ref stack, ++count);
            stack[count - 1] = number;
        }

        internal bool Pop()
        {
            if (stack.Length > 0)
            {
                double elementRemoved = stack[stack.Length - 1];
                Array.Resize(ref stack, --count);

                return true;
            }
            else
            {
                return false;
            }
        }

        internal double? Peek()
        {
            if (stack.Length != 0)
            {
                return stack[stack.Length - 1];
            }
            else
            {
                return null;
            }
        }

        internal bool IsEmpty()
        {
            if (stack.Length == 0)
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
