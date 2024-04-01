namespace _3._Number_1_9_as_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if  (num == 1)
                Console.WriteLine("one");
            else if (num == 2)
                Console.WriteLine("two");
            ...
            else if (num == 9)
                Console.WriteLine("nine");
            else
                Console.WriteLine("Out of range");

        }
    }
}