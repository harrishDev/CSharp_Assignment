using System;

namespace TicketBookingControlStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Ticket Booking System ---");
                Console.WriteLine("1. Check Ticket Availability");
                Console.WriteLine("2. Calculate Ticket Price");
                Console.WriteLine("3. Loop-based Booking");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        TicketAvailabilityCheck.Run();
                        break;
                    case "2":
                        TicketPriceCalculator.Run();
                        break;
                    case "3":
                        TicketBookingLoop.Run();
                        break;
                    case "4":
                        Console.WriteLine("Exiting... Thank you!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
