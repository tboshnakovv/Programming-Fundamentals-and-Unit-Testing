﻿int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

bool isIdentical = true; // true - масивите са еднакви //false - масивите не са еднакви

for (int index = 0; index <= firstArray.Length - 1; index++)
{
    if (firstArray[index] != secondArray[index])
    {
        //имаме различни елемнти на еднакви позиции -> масивите не са еднакви
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }
   
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}

