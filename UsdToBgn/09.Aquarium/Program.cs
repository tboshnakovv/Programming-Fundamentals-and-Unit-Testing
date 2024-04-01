namespace _09.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght  = int.Parse(Console.ReadLine());
            int width  = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double perc = double.Parse(Console.ReadLine());

            double volumeLiters = lenght * width * height * 0.001;

            double waterPerc = 1 - perc / 100;
            Console.WriteLine($"{volumeLiters * waterPerc:F2}");

        }
    }
}