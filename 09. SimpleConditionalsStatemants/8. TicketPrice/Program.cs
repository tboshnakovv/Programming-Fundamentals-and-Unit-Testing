﻿using System.ComponentModel.Design;

namespace _8._TicketPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();

            if (ticketType == "student")
                
                Console.WriteLine("$1.00");
            
            else if (ticketType == "regular") 
                
            Console.WriteLine("$1.60");
            
            else
            
                Console.WriteLine("Invalid ticket type!");
        }
    }
}