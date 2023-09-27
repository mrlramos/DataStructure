using System.Text;

namespace _2_SimpleManualQueue
{
    internal class SimpleManualQueue
    {
        string[] queue = Array.Empty<string>();
        short count = 0;

        internal bool Insert(string person)
        {
            Array.Resize(ref queue, ++count);
            queue[count - 1] = person;

            return true;
        }

        internal bool Remove()
        {
            if (count == 0)
            {
                return false;
            }

            if (count > 1)
            {
                for (short i = 0; i < count - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }
            }

            Array.Resize(ref queue, --count);

            return true;
        }

        internal string ListAll()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (queue.Length > 0)
            {
                for (int i = 0; i < queue.Length; i++)
                {
                    stringBuilder.Append(queue[i] + " ");
                }

                return stringBuilder.ToString();
            }
            else
            {
                return "Empty";
            }
            // return queue.Length > 0 ? queue : Array.Empty<string>();
        }

        internal short ListCount()
        {
            return (short)queue.Length;
        }
    }
}
