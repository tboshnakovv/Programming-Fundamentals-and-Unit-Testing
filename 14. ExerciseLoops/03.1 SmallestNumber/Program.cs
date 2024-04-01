namespace _03._BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine()); // броят на числата
            int minNumber = int.MaxValue; // най-малкото число

            for (int number = 1; number <= countNumbers; number++)
            {
                // променлива, в която съхраняваме стойността на числото
                int value = int.Parse(Console.ReadLine()); // стойността на числото

                // проверка дали е най-голямото
                if (value < minNumber)
                {
                    minNumber = value;
                }



            }
            // преминали сме през всички числа -> знаем кое е най - малкото
            Console.WriteLine(minNumber);
        }
    }
}