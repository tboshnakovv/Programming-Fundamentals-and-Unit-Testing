int n = int.Parse(Console.ReadLine());

//четирицифрени число: {digit1}{digit2}{digit3}{digit4}
// от 1000 до 9999
// digit1: 1; 9
// digit2: 0; 9
// digit3: 0; 9
// digit3: 0; 9

for (int digit1 = 1; digit1 <= 9; digit1 ++) //всички стойности на първата цифра
{
    for (int digit2 = 0; digit2 <= 9; digit2 ++) //всички стойности на втората цифра
    {
        for (int digit3 = 0; digit3 <= 9; digit3 ++) //всички стойности на третата цифра
        {
            for(int digit4 = 0; digit4 <= 9; digit4 ++) //всички стойности на четвъртата цифра
            {
                //четирицифрено числ: {digit1}{digit2}{digit3}{digit4}
                //проверка дали е happy: d1 + d2 = n И d2 + d3 = n
                if (digit1 + digit2 == n && digit3 + digit4 == n)
                {
                    //happy nimber !!!
                    {
                        Console.Write($"{digit1}{digit2}{digit3}{digit4} ");
                    }
                }
            }
        }
    }
}