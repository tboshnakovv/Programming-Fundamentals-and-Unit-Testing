namespace _01.NumbersEndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 997; i++)
            {
                if (i % 10 == 7) //a number ends in 7, if it's modulo 10 result is 7
                    Console.WriteLine(i);
            }
        }
    }
}