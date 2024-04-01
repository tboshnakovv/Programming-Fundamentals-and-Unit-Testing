int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach (int number in firstArray)
{
    for(int i = 0; i < secondArray.Length; i++)
    {
        if (secondArray[i] == number)
        {
            Console.Write(number + " ");
        }
    }
}