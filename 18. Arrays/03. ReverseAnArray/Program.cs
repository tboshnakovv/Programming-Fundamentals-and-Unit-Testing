int n = int.Parse(Console.ReadLine()); //Брой числа, с които ще работя

int[]numbers = new int[n];   //създаваме празен масив за целочислени стойности

for (int index = 0; index <= numbers.Length - 1; index++) //цикъл, който обхожда масива отпред назад
{
    numbers[index] = int.Parse(Console.ReadLine());
}

//{10, 20, 30} -> reverse -> {30, 20, 10}
// от последния към първия индекс

for (int index = numbers.Length - 1; index >= 0; index--) // цикъл, който обхожда масива отзад напред
{
    Console.Write(numbers[index] + " ");
}