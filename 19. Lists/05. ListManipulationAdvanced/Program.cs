using System.ComponentModel.Design;

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{

    if (command.StartsWith("Contains"))
    {
        int number = int.Parse(command.Split(" ")[1]);
        if (numbers.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command.StartsWith("PrintEven"))
    {

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (command.StartsWith("PrintOdd"))
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (command == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (command.StartsWith("Filter"))
    {
        string condition = command.Split(" ")[1];
        int number = int.Parse(command.Split(" ")[2]);

        switch (condition)
        {
            case "<":
                numbers.RemoveAll(n => n >= number);
                break;
            case ">":
                numbers.RemoveAll(n => n <= number);
                break;
            case "<=":
                numbers.RemoveAll(n => n > number);
                break;
            case ">=":
                numbers.RemoveAll(n => n < number);
                break;
        }
    }


    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));