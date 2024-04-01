int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

//1. Сумата на четните числа в масива
int sumEven = 0;
//2. Сумата на нечетните числа в масива
int sumOdd = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        //четно
        sumEven += number;
    }
    else
    {
        //нечетно
        sumOdd += number;
    
    }
        
    
}


//3. От сумата на четните да извадим нечетните
Console.WriteLine(sumEven - sumOdd);
