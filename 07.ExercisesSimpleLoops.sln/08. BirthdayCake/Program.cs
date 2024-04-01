namespace _08._BirthdayCake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int cakeSize = width * height;
           

            while (cakeSize >= 0)
            {
                String input = Console.ReadLine();
                if (input == "STOP")
                    break;

                cakeSize -= int.Parse(input);
            }

            if (cakeSize >= 0)
                Console.WriteLine($"{cakeSize} pieces are left.");
            else
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
        }
    }
}