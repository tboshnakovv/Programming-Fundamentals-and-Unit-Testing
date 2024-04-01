//комбинация: {letter1}{letter2}{letter3}

char startLetteer = char.Parse(Console.ReadLine()); //начална буква
char endLetter = char.Parse(Console.ReadLine()); //крайна буква
char excludedLetter = char.Parse(Console.ReadLine()); //буква за икзлючване

//letter1: [startetLetter; endLetter]
//letter2: [startLetter; endLetter]
//letter3: [startLetter; endLetter]

int count = 0; //брой на валидните комбинации

//всички комбинации
for (char letter1 = startLetteer; letter1 <= endLetter; letter1 ++)
{
    for (char letter2 = startLetteer; letter2 <= endLetter; letter2 ++)
    {
        for (char letter3 = startLetteer; letter3 <= endLetter; letter3 ++)
        {
            //комбинация: {letter1}{letter2}{letter3}
            //изключваме комбинации, които съдържат excludedLetter
            if (letter1 != excludedLetter && letter2 != excludedLetter && letter3 != excludedLetter)
            {
                //комбинация, в която няма буква за изключване (excludedLetter)
                Console.Write($"{letter1}{letter2}{letter3} ");
                count++;
            }
        }
    }
}
//принтирали сме всички комбинации
Console.WriteLine(); //сваляме курсора на нов ред, за да може следващата стойност да се отпечата на нов ред
Console.WriteLine(count);