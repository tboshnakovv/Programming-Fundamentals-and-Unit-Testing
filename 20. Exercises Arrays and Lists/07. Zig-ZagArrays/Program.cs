using System.Runtime.ExceptionServices;

int count = int.Parse(Console.ReadLine());

List<int> firtsList = new List<int>();
List<int> secondList = new List<int>();

for (int i = 0; i < count; i++)
{
    List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

    int num1 = numbers[0];
    int num2 = numbers[1];

    if (i % 2 == 0)
    {
        firtsList.Add(num1);
        secondList.Add(num2);
    }
    else
    {
        firtsList.Add(num2);
        secondList.Add(num1);
    }
    
}

Console.WriteLine(string.Join(" ", firtsList));
Console.WriteLine(string.Join(" ", secondList));