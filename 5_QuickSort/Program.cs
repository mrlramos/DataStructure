// See https://aka.ms/new-console-template for more information

using _5_QuickSort;

int[] ages = { 5, 20, 4, 2};

for (int i = 0; i < ages.Length; i++)
{
    Console.WriteLine(ages[i]);
}

QuickSort quickSort = new();

quickSort.Sort(ref ages, 0, ages.Length - 1);
Console.WriteLine("\n");

for (int i = 0; i< ages.Length; i++)
{
    Console.WriteLine(ages[i]);
}

Console.ReadLine();

