List <int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

//повтарящо се действие: въвеждаме входни данни (команди)
//стоп: входните данни са равни == "еnd"
//продължамае когато входните данни са различни от !="end"

string command = Console.ReadLine();
while (command != "end")
{
    //валидна команда
    //1. command = "Delete 5" -> ["Delete","5"]
    //2. command = "Insert 5 0"

    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0]; //име на командата
    int element = int.Parse(commandParts[1]);

    if (commandName == "Delete")
    {
        //delete all elements in the array, which are equal to the given element
        numbers.RemoveAll(number => number == element);
    }
    else if (commandName == "Insert")
    {
        int position = int.Parse(commandParts[2]);
        //insert the element at the given position
        numbers.Insert(position, element);

    }



    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));