namespace _06._Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op1 = int.Parse(Console.ReadLine());
            int op2 = int.Parse(Console.ReadLine());
            String operation  = Console.ReadLine();

            int result = 0;
            String modDiv = "";

            switch (operation)
            {
                case "*":
                case "-":
                case "+":
                    switch (operation)
                    {
                        case "-":
                            result = op1 - op2;
                            break;
                        case "+":
                            result = op1 + op2;
                            break;
                        case "*":
                            result = op1 * op2;
                    }
            }
        }
    }
}