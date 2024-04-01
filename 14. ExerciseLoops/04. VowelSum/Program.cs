﻿using System.ComponentModel.Design;

namespace _04._VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countCharacters = int.Parse(Console.ReadLine());
            //countCharacters = повтаряме: въвеждаме символ 

            int sumValues = 0; //сумата от стойностите на гласните букви

            for (int i = 1; i <= countCharacters; i++)
            {
                char symbol  = char.Parse(Console.ReadLine()); //въведеният символ

                //проверка дали е гласна буква a, e, i, o, u
                //серия от проверки за точни стойности -> switch
                switch (symbol)
                {
                    case 'a':
                        //стойност = 1
                        sumValues += 1;
                        break;
                    case 'e':
                        //стойност = 2 
                        sumValues += 2;
                        break;
                    case 'i':
                        //стойност = 3
                        sumValues += 3;
                        break;
                    case 'o':
                        //стойност = 4
                        sumValues += 4;
                        break;
                    case 'u':
                        //стойност = 5
                        sumValues += 5;
                        break;
                }

            }
                //преминали сме през всички символи -> стойност -> сумирали
                Console.WriteLine(sumValues);
        }
    }
}