// Read a number from the console and analyse digits

int result = int.Parse(Console.ReadLine());

int totalResult = 0;

while(result != 0)
{
    int digit = result % 10;

    if(digit % 2 == 0)
    {
        int resultFactorial = CalculateFactoriral(digit);
        totalResult += resultFactorial;

    }

    result = result / 10;
}

Console.WriteLine(totalResult);


// Calculate Factorial
static int CalculateFactoriral(int number)
{
    int result = 1;

    while(number > 0)
    {
        result = result * number;
        number -= 1;
    }

    return result;
}