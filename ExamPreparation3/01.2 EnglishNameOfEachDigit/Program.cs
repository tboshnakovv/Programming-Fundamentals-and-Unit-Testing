int number = int.Parse(Console.ReadLine());

string output = "";
string[] digits = new string[] { "zero", "one", "two", "three", "four", 
                                "five", "six", "seven", "eight", "nine" };

while (number > 0)
{
    int digit = number % 10;
    number = number / 10;

    output = output + digits[digit] + "\n";
}

Console.WriteLine(output);