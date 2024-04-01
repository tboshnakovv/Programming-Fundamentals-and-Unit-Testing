namespace _03.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favorite = Console.ReadLine();

            string current = Console.ReadLine();
            int checkBooks = 0;

            while (current != "No More Books" && current != favorite)
            {
                checkBooks++; //we just procesed a book, inciadate this!
                current = Console.ReadLine(); // get the nex book
            }

            if (current == favorite)
                Console.Write($"You checked {checkBooks} books and found it.");
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkBooks} books.");
            }
        }
    }
}