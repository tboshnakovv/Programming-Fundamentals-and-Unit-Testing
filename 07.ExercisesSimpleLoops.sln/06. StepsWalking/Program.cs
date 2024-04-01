namespace _06._StepsWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10000;

            int stepsToday = 0;
            String input;
            bool finished = false;

            while (!finished && stepsToday < stepsGoal)
            {
                input = Console.ReadLine(); //read the input

                if (input == "Going home") // is she too tired?
                {
                    finished = true; // she goes home
                    input = Console.ReadLine();
                }

                stepsToday += int.Parse(input); // add the latest input to today's steps
            }

            if (stepsToday < stepsGoal) //she's under the goal
                Console.WriteLine($"{stepsGoal - stepsToday} more steps to reach goal.");
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsToday - stepsGoal} steps over the goal!");
            }
        }
    }
}