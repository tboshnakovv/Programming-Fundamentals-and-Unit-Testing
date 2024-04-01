namespace _06._TravelSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double neededSum = double.Parse(Console.ReadLine());
                double collectetSum = 0;
                while (collectetSum < neededSum)
                {
                    double sumToBeAdded = double.Parse(Console.ReadLine());
                    collectetSum += sumToBeAdded;
                    Console.WriteLine($"Collected: {collectetSum:F2}");
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}