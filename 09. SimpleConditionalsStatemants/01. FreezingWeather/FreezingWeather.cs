namespace _01._FreezingWeather
{
    internal class FreezingWeather
    {
        static void Main(string[] args)
        {
          int temeperature = int.Parse(Console.ReadLine());

            if (temeperature < 0)
            {
                Console.WriteLine("Freezing weather!");
            }
        }
    }
}