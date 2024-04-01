using System.Threading.Channels;

namespace _06._SequeanceOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetNumber = int.Parse(Console.ReadLine());
            int k = 1;
            while (k <= targetNumber)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}