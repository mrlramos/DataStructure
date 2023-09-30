namespace _5_QuickSort
{
    internal class QuickSort
    {
        internal void Sort(ref int[] v, int start_pos, int end_pos)
        {
            var pivot = v[start_pos];
            int l = start_pos;
            int r = end_pos;

            while (l <= r)
            {
                while (v[l] < pivot) l++;
                while (v[r] > pivot) r--;

                if (l <= r)
                {
                    int temp = v[l];
                    v[l] = v[r];
                    v[r] = temp;
                    //(v[l], v[r]) = (v[r], v[l]); do the same thing at three lines above
                    l++;
                    r--;
                }
            }

            if (start_pos < r)
            {
                Sort(ref v, start_pos, r);
            }
            if (l < end_pos)
            {
                Sort(ref v, l, end_pos);
            }
        }
    }
}
