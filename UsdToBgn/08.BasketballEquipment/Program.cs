namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double sneakersPrice = annualFee * 0.6;
            double teamPrice = sneakersPrice * 0.8;
            double baskedballPrice = teamPrice * 0.25;
            double accessoriesPrice = baskedballPrice * 0.2;

            double totalBasketCoast = annualFee + sneakersPrice + teamPrice + baskedballPrice + accessoriesPrice;
            Console.WriteLine(totalBasketCoast);
        }
    }
}