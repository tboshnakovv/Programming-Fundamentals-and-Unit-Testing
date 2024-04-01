namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int veganMenus = int.Parse(Console.ReadLine());

            double chickenPrice = chickenMenus * 10.35;
            double fishPrice = fishMenus * 12.40;
            double veganPrice = veganMenus * 8.15;
            double totalMenusPrice = chickenPrice + fishPrice + veganPrice;
            double desertPrice = totalMenusPrice * 0.2;

            double grandTotal = totalMenusPrice + desertPrice + 2.50;

            Console.WriteLine(grandTotal);



        }
    }
}