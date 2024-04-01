﻿namespace _05._VacationSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());

            int totalDays = 0;
            int spendingDays = 0;

            while (moneyAvailable < moneyNeeded && spendingDays < 5)
            {
                totalDays++;
                String type = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                if (type == "spend")
                {
                    moneyAvailable -= amount;
                    if (moneyAvailable < 0)
                        moneyAvailable = 0;
                    spendingDays++;
                }
                else
                {
                    moneyAvailable += amount;
                    spendingDays = 0; //we're saving - reset the spending sequence
                }

                if (spendingDays >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(totalDays);
                }
                else if (moneyAvailable >= moneyNeeded)
                    Console.WriteLine($"You saved the money for {totalDays} days.");
                    
            }
        }
    }
}