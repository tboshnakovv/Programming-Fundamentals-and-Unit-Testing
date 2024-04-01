int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

double factorial1 = CalculateFactorial(num1);
double factorial2 = CalculateFactorial(num2);

double result = factorial1 / factorial2;
Console.WriteLine(result);

static double CalculateFactorial(int number)
{
    double factorial = 1.0;

    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }

    return factorial;
}