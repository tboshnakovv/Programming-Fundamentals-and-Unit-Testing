﻿string text = Console.ReadLine();

//броя на гласните букви в текста
//гласни букви: А, а, Е, е, I, i, U, u, O, o
Console.WriteLine(GetVowelsCount(text));


//метод, който намира и връща като резултат броят на гласните букви

static int GetVowelsCount (string text)
{
    int count = 0; //брой на гласните букви
    //всички букви в текст
    {
        for (int position = 0; position <= text.Length - 1; position ++)
        {
            char symbol = text[position]; //символа на текущата позиция
            //проверка дали е гласна буква
            
                if (symbol == 'A' || symbol == 'a'
                    || symbol == 'E' || symbol == 'e'
                    || symbol == 'I' || symbol == 'i'
                    || symbol == 'O' || symbol == 'o'
                    || symbol == 'U' || symbol == 'u')
                {
                  //гласна буква
                  count++;

                }
        }
        
        //брой на гласните букви
        return count;
    }
}
            
            

            
            