namespace _01._PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            int result = 1; //резултатът от степенуването
            for (int time = 1; time <= power; time ++)
            {
                result = result * number;
            }
            Console.WriteLine(result);
        }
    }
}