namespace _02._2._EqualSumsOfEvenAndOddPositions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine()); 
            int secondNum = int.Parse(Console.ReadLine()); 

            for (int i = firstNum; i <= secondNum; i++)
            {
                String currentNum = i.ToString(); 

                int oddSum = 0; 
                int eventSum = 0; 
                for (int j = 0; j < currentNum.Length; j++) 
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());

                    if (j % 2 ==0)
                        eventSum += currentDigit;
                    else
                        oddSum += currentDigit;
                }

                if (oddSum == eventSum)
                    Console.Write(i + " ");
            }
        }
    }
}