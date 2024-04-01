namespace _03._BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine()); // броят на числата
            int maxNumber = int.MinValue; // най-голямото число

            for (int number = 1; number <= countNumbers; number++)
            {   
                // променлива, в която съхраняваме стойността на числото
                int value = int.Parse(Console.ReadLine()); // стойността на числото

                // проверка дали е най-голямото
                if (value > maxNumber)
                {
                    maxNumber = value;
                }

               

            }
                // преминали сме през всички числа -> знаем кое е най - голямото
                Console.WriteLine(maxNumber);
        }
    }
}