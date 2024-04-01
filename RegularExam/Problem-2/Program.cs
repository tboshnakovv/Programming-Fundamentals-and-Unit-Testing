using System;

int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int lastIndex = arr.Length - 1;
    int temp = arr[lastIndex];
    for (int j=arr.Length - 1; j > 0; j--)
    {
        arr[j] = arr[j - 1];
    }
    arr[0] = temp;

}
Console.WriteLine(string.Join(", ", arr));