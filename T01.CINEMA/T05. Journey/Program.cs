using System.Security;

namespace T05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            String seasons = Console.ReadLine();

            String destination = "";
            String holidayType = "";
            double holidayCost = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (seasons == "summer")
                {
                    holidayCost = budget * 0.3;
                    holidayType = "Camp";
                }
                else
                {
                    holidayCost = budget * 0.7;
                    holidayType = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (seasons == "summer")
                {
                    holidayCost = budget * 0.4;
                    holidayType = "Camp";
                }
                else
                {

                    holidayCost = budget * 0.8;
                }
            } else
            {
                destination = "Europe";
                holidayCost = budget * 0.9;
                holidayType = "Hotel";

            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {holidayCost}");

        }
    }
}