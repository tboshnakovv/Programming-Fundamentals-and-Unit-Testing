namespace _03._Sequence2k___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            int num = 1;

            while (num <= limit)
            {

                Console.WriteLine(num);
                num = num * 2 + 1;

            }


           
        }
    }
}