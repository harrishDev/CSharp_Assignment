using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingControlStructures
{
    class TicketBookingLoop
    {
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("\nTicket Types: Silver, Gold, Diamond");
                Console.Write("Enter ticket type or 'exit' to quit: ");
                string type = Console.ReadLine().ToLower();

                if (type == "exit")
                {
                    Console.WriteLine("Thank you for using the Ticket Booking System.");
                    break;
                }

                Console.Write("Enter number of tickets: ");
                int count = Convert.ToInt32(Console.ReadLine());

                double price = type switch
                {
                    "silver" => 500,
                    "gold" => 1000,
                    "diamond" => 1500,
                    _ => -1
                };

                if (price == -1)
                {
                    Console.WriteLine("Invalid ticket type.");
                    continue;
                }

                double total = price * count;
                Console.WriteLine($"Total cost: ₹{total}");
            }
        }
    }
}
