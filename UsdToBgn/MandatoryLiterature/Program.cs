namespace MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int readingdays = int.Parse(Console.ReadLine());

            int hoursForTheBook = totalPages / pagesPerHour; // the numbers of hours we need to read the book
            int hoursReadingPerDay = hoursForTheBook / readingdays;

            Console.WriteLine(hoursReadingPerDay);
        }

    }
}