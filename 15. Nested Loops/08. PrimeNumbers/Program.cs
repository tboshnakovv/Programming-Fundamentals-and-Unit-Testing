namespace _08._PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());


            for (int currentNumber = start;  currentNumber <= end; currentNumber += 1)
            {
                bool isPrime = true;
                int divider = 2;

                while (divider < end)
                {
                    if (currentNumber == divider)
                    {
                        divider += 1;
                        continue;
                    }

                    if (currentNumber % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }

                    divider += 1;
                }

                if (isPrime)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}