namespace TeachengMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPacks = int.Parse(Console.ReadLine());
            int markerPacks = int.Parse(Console.ReadLine());
            int boardCleanerLiters = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pensPrice = 5.80 * penPacks;
            double markersPrice = 7.20 * markerPacks;
            double boardCleanerPrice = 1.20 * boardCleanerLiters;
            double totalPrice = pensPrice + markersPrice + boardCleanerPrice;
            double discountAmount = totalPrice * discount / 100;
            double neededMoney = totalPrice - discountAmount;
            Console.WriteLine(neededMoney);
        }
    }
}