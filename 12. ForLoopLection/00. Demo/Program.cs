namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int index = 1; index <= 20; index += 1)
            //{
            //    Console.WriteLine(index);
            //}




            for (int number = 1; number <= 20; number += 1)
            {
                Console.WriteLine(number);

                int squiereOfNumber = number * number;
                Console.WriteLine("Squire of number: " + squiereOfNumber);
            }
        }
    }
}