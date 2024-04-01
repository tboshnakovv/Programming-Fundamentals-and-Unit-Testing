List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine(); //входни данни 

while (command != "end")
{
    //1. command = "Add 3"
    if (command.StartsWith("Add"))
    {
        //command = "Add 3"
        //add a number to the end of the list
        int numberToAdd = int.Parse(command.Split(" ")[1]);
        numbers.Add(numberToAdd);
    }
    
    else if (command.StartsWith("RemoveAt"))
    {
        //command = "RemoveAt 0"
        //remove a number at a given index
        int indexToremove = int.Parse(command.Split(" ")[1]);
        numbers.RemoveAt(indexToremove);
    }

    else if (command.StartsWith("Remove"))
    {
        //command = "Remove 4"
        int numberToRemove = int.Parse(command.Split(" ")[1]);
        numbers.Remove(numberToRemove);
    }
    else if (command.StartsWith("Insert"))
    {
        //command = "Insert 10 0"
        //insert a number at a given index
        int numbersToInsert = int.Parse(command.Split(" ")[1]);
        int indexToInsert = int.Parse(command.Split(" ")[2]);
        numbers.Insert(indexToInsert, numbersToInsert);
    }


    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));

    





