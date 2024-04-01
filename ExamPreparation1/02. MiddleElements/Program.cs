// Read an array of integers

double[] rawArray = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
double[] inputArray = new double[rawArray.Length];

for (int i = 0; i < rawArray.Length; i++)
{
    inputArray[i] = rawArray[i];
}

//Find the middle numbers

int middleRightElemendIndex = inputArray.Length / 2;
int middleLefttElemendIndex = middleRightElemendIndex - 1;

double middleElementsAverage = (inputArray[middleRightElemendIndex] + inputArray[middleLefttElemendIndex]) / 2;
Console.WriteLine($"{middleElementsAverage:F2}");