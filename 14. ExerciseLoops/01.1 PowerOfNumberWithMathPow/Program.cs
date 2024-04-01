namespace _01._1_PowerOfNumberWithMathPow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(number, power));
        }
    }
}