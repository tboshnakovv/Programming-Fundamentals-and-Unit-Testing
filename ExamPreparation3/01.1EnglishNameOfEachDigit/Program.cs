int number = int.Parse(Console.ReadLine());

string output = "";

while (number > 0)
{
    int digit = number % 10;
    number = number / 10;

    if (digit == 0) output = output + "zero" + "\n";
    else if (digit == 1) output = output + "one" + "\n";
    else if (digit == 2) output = output + "two" + "\n";
    else if (digit == 3) output = output + "three" + "\n";
    else if (digit == 4) output = output + "four" + "\n";
    else if (digit == 5) output = output + "five" + "\n";
    else if (digit == 6) output = output + "six" + "\n";
    else if (digit == 7) output = output + "seven" + "\n";
    else if (digit == 8) output = output + "eight" + "\n";
    else if (digit == 9) output = output + "nine" + "\n";
}
Console.WriteLine(output);