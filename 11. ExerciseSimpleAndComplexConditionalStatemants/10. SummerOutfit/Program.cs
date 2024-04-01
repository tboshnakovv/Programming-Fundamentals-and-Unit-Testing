using System.ComponentModel.Design;

namespace T02._summerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());

            String tod = Console.ReadLine();

            String clothing = "", shoes = "";

            if (tod == "Morning")

            {
                if (10 <= temp && temp <= 18)
                {
                    clothing = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (18 < temp && temp <= 24)
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temp >= 24)
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (tod == "Afternoon")
            {
                if (10 <= temp && temp <= 18)
                {
                    clothing = "Shirts";
                    shoes = "Moccasins";
                }
                else if (18 < temp && temp <= 24)
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (temp >= 24)
                {
                    clothing = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (tod == "Evening")
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }
            Console.WriteLine($"It's {temp} degrees, get your {clothing} and {shoes}.");
        }
    }
}