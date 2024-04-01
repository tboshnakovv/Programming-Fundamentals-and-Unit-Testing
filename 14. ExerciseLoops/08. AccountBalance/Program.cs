namespace _08._AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double balance = 0;

            while (command != "End")
            {
                double money = Convert.ToDouble(command);
                balance += money;

                if (money > 0)
                {
                    Console.WriteLine($"Increase: {money:f2}");
                }
                else
                {
                    Console.WriteLine($"Decrease: {Math.Abs(money):f2}");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Balance: {balance:f2}");

        }
    }
}