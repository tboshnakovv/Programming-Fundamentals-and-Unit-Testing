namespace _07._VowelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch = Console.ReadLine();

            switch (ch)
            {
                case "A":
                case "a":
                case "E":
                case "e":
                case "O":
                case "o":
                case "I":
                case "i":
                case "U":
                case "u":
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;



            }
        }
    }
}