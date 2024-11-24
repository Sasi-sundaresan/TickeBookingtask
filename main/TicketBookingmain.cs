using AssignmentTask.model;
using AssignmentTask.Repository;
using AssignmentTask.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentTask.main
{
    internal class TicketBookingmain  : BookingService
    {
        private static BookingService ticketService;

       
        public TicketBookingmain() 
        {
            ticketService = new BookingService();
        }

        public void ShowMenu()
        {
            string command = "";
            while (command != "exit")
            {
                // Display menu options
                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1. create_event");
                Console.WriteLine("2. book_tickets");
                Console.WriteLine("3. cancel_tickets");
                Console.WriteLine("4. get_available_seats");
                Console.WriteLine("5. get_event_details");
                Console.WriteLine("6. exit");

                // Get the user's choice
                command = Console.ReadLine().ToLower();

                // Execute the corresponding method based on user input
                switch (command)
                {
                    case "1":
                    case "create_event":
                        CreateEvent();
                        break;

                    case "2":
                    case "book_tickets":
                        BookTickets();
                        break;

                    case "3":
                    case "cancel_tickets":
                        CancelTickets();
                        break;

                    case "4":
                    case "get_available_seats":
                        GetAvailableSeats();
                        break;

                    case "5":
                    case "get_event_details":
                        GetEventDetails();
                        break;

                    case "6":
                    case "exit":
                        Console.WriteLine("Exiting the system...");
                        break;

                    default:
                        Console.WriteLine("Invalid option! Please try again.");
                        break;
                }
            }
        }

        // Method to create an event
        private void CreateEvent()
        {
            try
            {
                Console.WriteLine("\nEnter event details:");

                Console.Write("Event Name: ");
                string eventName = Console.ReadLine();

                Console.Write("Event Date (yyyy-mm-dd): ");
                DateTime eventDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Event Time (hh:mm): ");
                TimeSpan eventTime = TimeSpan.Parse(Console.ReadLine());

                Console.Write("Venue Name: ");
                string venueName = Console.ReadLine();

                Console.Write("Total Seats: ");
                int totalSeats = int.Parse(Console.ReadLine());

                Console.Write("Ticket Price: ");
                decimal ticketPrice = decimal.Parse(Console.ReadLine());

                Console.Write("Event Type (1 for Concert, 2 for Sports, 3 for Theater): ");
                Event.EventType eventType = (Event.EventType)Enum.Parse(typeof(Event.EventType), Console.ReadLine());

                // Create event object and pass it to the BookingService
                Event newEvent = new Event(eventName, eventDate, eventTime, venueName, totalSeats, ticketPrice, eventType);
                ticketService.CreateEvent(newEvent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Method to book tickets
        private void BookTickets()
        {
            try
            {
                Console.Write("\nEnter Event ID to book tickets: ");
                int eventId = int.Parse(Console.ReadLine());

                Console.Write("Enter number of tickets to book: ");
                int numTickets = int.Parse(Console.ReadLine());

                // Call service to book tickets
                ticketService.BookTickets(eventId, numTickets);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Method to cancel tickets
        private void CancelTickets()
        {
            try
            {
                Console.Write("\nEnter Event ID to cancel tickets: ");
                int eventId = int.Parse(Console.ReadLine());

                Console.Write("Enter number of tickets to cancel: ");
                int numTickets = int.Parse(Console.ReadLine());

                // Call service to cancel tickets
                ticketService.CancelTickets(eventId, numTickets);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Method to get available seats for an event
        private void GetAvailableSeats()
        {
            try
            {
                Console.Write("\nEnter Event ID to check availability: ");
                int eventId = int.Parse(Console.ReadLine());

                Console.Write("Enter number of tickets to check: ");
                int numTickets = int.Parse(Console.ReadLine());

                // Call service to check availability
                ticketService.CheckAvailability(eventId, numTickets);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Method to get event details
        private void GetEventDetails()
        {
            try
            {
                Console.Write("\nEnter Event ID to get details: ");
                int eventId = int.Parse(Console.ReadLine());

                // Call service to display event details
                ticketService.DisplayEventDetails(eventId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }






    }
}
