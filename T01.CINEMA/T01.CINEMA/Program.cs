namespace T01.CINEMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string screening = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double totalPrice = rows * cols;   //total seats in the Cinema

            if (screening == "Premiere")
            {
                totalPrice = totalPrice * 12;
            }else if (screening == "Normal") 
            {
                totalPrice = totalPrice * 7.50;
            }else if (screening == "Discount") 
            {
                totalPrice *= 5;
            }

            Console.WriteLine("{0:f2} leva", totalPrice);
        }
    }
}