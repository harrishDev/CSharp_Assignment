using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingControlStructures
{
    class TicketAvailabilityCheck
    {
        public static void Run()
        {
            Console.Write("Enter available tickets: ");
            int availableTickets = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of tickets to book: ");
            int bookingTickets = Convert.ToInt32(Console.ReadLine());

            if (availableTickets >= bookingTickets)
            {
                availableTickets -= bookingTickets;
                Console.WriteLine("Booking successful!");
                Console.WriteLine("Remaining tickets: " + availableTickets);
            }
            else
            {
                Console.WriteLine("Booking failed! Not enough tickets available.");
            }
        }
    }
}
