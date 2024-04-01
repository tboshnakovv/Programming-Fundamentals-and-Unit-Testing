namespace _03._3._SumOfPrimeAndNon_PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfPrimes = 0;
            int sumOfNonPrimes = 0;

            while(true)
            {
                String input = Console.ReadLine(); //get the nex input

                if (input == "stop")
                    break; // we're done

                int number = int.Parse(input); // the input is a number, make it 'int'

                if (number < 0) // negative numbers require special treatment!
                {
                    Console.WriteLine("Number is negative.");
                    continue; //let's continue with our cycle from its beginning

                }

                int devisors = 0;
                for (int i = 1; i <= number; i++)
                    if (number % i == 0)
                        devisors++;

                if (devisors == 2)
                    sumOfPrimes += number;

                else
                    sumOfNonPrimes += number;

            }

            Console.WriteLine("Sum of all prime numbers is: " + sumOfPrimes);
            Console.WriteLine("Sum of all non prime numbers is: " + sumOfNonPrimes);
        }
    }
}