int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach (int number in firstArray)
{
    if (secondArray.Contains(number))
    {
        Console.Write(number + " ");
    }
}