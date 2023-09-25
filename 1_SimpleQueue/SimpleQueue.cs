using System.Text;

namespace _1_SimpleQueue
{
    internal class SimpleQueue
    {
        Queue<string> queue = new();

        public void Insert(string person)
        {
            queue.Enqueue(person);
        }

        public bool Remove()
        {
            if (queue.Count > 0)
            {
                queue.Dequeue();
                return true;
            }
            return false;
        }

        public List<string> ListAll()
        {
            return queue.ToList();
        }

        public short ListCount()
        {
            return (short)queue.Count;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            foreach (string s in queue.ToList()) 
            {
                stringBuilder.Append(s + " ");
            }

            return stringBuilder.ToString();
        }
    }
}
