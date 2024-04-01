static int CalculateReactArea (int width, int height)
{
    return width * height;
}

int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int area = CalculateReactArea(width, height);

Console.WriteLine(area);

