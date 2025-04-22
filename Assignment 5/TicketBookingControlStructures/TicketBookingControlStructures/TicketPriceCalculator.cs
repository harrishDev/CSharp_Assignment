using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingControlStructures
{
    class TicketPriceCalculator
    {
        public static void Run()
        {
            Console.WriteLine("Ticket Types: Silver, Gold, Diamond");
            Console.Write("Enter ticket type: ");
            string type = Console.ReadLine().ToLower();

            Console.Write("Enter number of tickets: ");
            int count = Convert.ToInt32(Console.ReadLine());

            double price = 0;

            if (type == "silver")
            {
                price = 500;
            }
            else if (type == "gold")
            {
                price = 1000;
            }
            else if (type == "diamond")
            {
                price = 1500;
            }
            else
            {
                Console.WriteLine("Invalid ticket type.");
                return;
            }

            double totalCost = price * count;
            Console.WriteLine($"Total cost for {count} {type} tickets: ₹{totalCost}");
        }
    }
}
