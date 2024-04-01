namespace _9._AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "square")
            {
                double size = double.Parse(Console.ReadLine());
                double area = size * size;
                Console.WriteLine($"{area:F2}");
            }
            else if (type == "rectangle")
            {
                double sizeA = double.Parse(Console.ReadLine());
                double sizeB = double.Parse(Console.ReadLine());
                double area = sizeA * sizeB;
                Console.WriteLine($"{area:F2}");
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:F2}");
                
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }

        }
    }
}