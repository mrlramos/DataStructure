// See https://aka.ms/new-console-template for more information

int[] ages = { 5, 20, 4, 2};

for (int i = 0; i < ages.Length; i++)
{
    Console.WriteLine(ages[i]);
}

QuickSort(ages, 0, ages.Length - 1);
Console.WriteLine("\n");

for (int i = 0; i< ages.Length; i++)
{
    Console.WriteLine(ages[i]);
}

Console.ReadLine();

void QuickSort(int[] v, int start_pos, int end_pos)
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

    if (start_pos < r )
    {
        QuickSort(v, start_pos, r);
    }
    if (l < end_pos)
    {
        QuickSort(v, l, end_pos);
    }
}