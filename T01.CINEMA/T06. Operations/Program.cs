namespace T06._Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op1 = int.Parse(Console.ReadLine());
            int op2 = int.Parse(Console.ReadLine());    
            String operation = Console.ReadLine();

            int result = 0;
            String modDiv = 0;

            switch (operation)
            {
                
              case  "-": 
                    op2 = -op2;
               case "+": 
                    result = op1 + op2;
                    if (result % 2 == 0)
                        modDiv = " - even";
                    else
                        modDiv = " - odd";
                    Console
            }
        }
    }
}