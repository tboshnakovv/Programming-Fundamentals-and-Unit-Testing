int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

PrintSign(number1, number2, number3);

//метод, който отпечатва каква е стойността на произведението на числата


static void PrintSign(int n1, int n2, int n3)
{
    //product = n1* n2* n3
    //product < 0; product > 0; product == 0

    //начин 1
    int product = n1 * n2 * n3;
    if (product < 0)
    {
        Console.WriteLine("negative");
    }
    else if (product > 0)
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("zero");
    }
}   
