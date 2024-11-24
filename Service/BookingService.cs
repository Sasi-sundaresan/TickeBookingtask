using AssignmentTask.model;
using AssignmentTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask.Service
{
    internal class BookingService : Ticketbookingsystem

    {

        private ITicketBooking _ticketBookingRepository;

        public BookingService()
        {
            _ticketBookingRepository = new Ticketbookingsystem();
        }

        public bool CreateEvent(Event eventObj)
        {
            try
            {
                bool result = _ticketBookingRepository.CreateEvent(
                    eventObj.EventName, eventObj.EventDate, eventObj.EventTime,
                    eventObj.VenueName, eventObj.TotalSeats,
                    eventObj.TicketPrice, eventObj.Type.ToString()
                );

                if (result)
                {
                    Console.WriteLine($"Event '{eventObj.EventName}' created successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to create the event.");
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while creating the event: {ex.Message}");
                return false;
            }
        }

        public bool BookTickets(int eventId, int numTickets)
        {
            try
            {
                bool result = _ticketBookingRepository.BookTickets(eventId, numTickets);

                if (result)
                {
                    Console.WriteLine($"{numTickets} tickets booked successfully for Event ID: {eventId}!");
                }
                else
                {
                    Console.WriteLine("Not enough seats available for booking.");
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while booking tickets: {ex.Message}");
                return false;
            }
        }

        public bool CancelTickets(int eventId, int numTickets)
        {
            try
            {
                bool result = _ticketBookingRepository.CancelTickets(eventId, numTickets);

                if (result)
                {
                    Console.WriteLine($"{numTickets} tickets canceled successfully for Event ID: {eventId}!");
                }
                else
                {
                    Console.WriteLine("Cannot cancel more tickets than booked.");
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while canceling tickets: {ex.Message}");
                return false;
            }
        }

        public void DisplayEventDetails(int eventId)
        {
            try
            {
                Event eventObj = _ticketBookingRepository.GetEventDetails(eventId);

                if (eventObj != null)
                {
                    Console.WriteLine("Event Details:");
                    Console.WriteLine($"Name: {eventObj.EventName}");
                    Console.WriteLine($"Date: {eventObj.EventDate}");
                    Console.WriteLine($"Time: {eventObj.EventTime}");
                    Console.WriteLine($"Venue: {eventObj.VenueName}");
                    Console.WriteLine($"Total Seats: {eventObj.TotalSeats}");
                    Console.WriteLine($"Available Seats: {eventObj.AvailableSeats}");
                    Console.WriteLine($"Price: {eventObj.TicketPrice}");
                }
                else
                {
                    Console.WriteLine($"No event found with ID: {eventId}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while displaying event details: {ex.Message}");
            }
        }

        public bool CheckAvailability(int eventId, int numTickets)
        {
            try
            {
                int availableSeats = _ticketBookingRepository.GetAvailableSeats(eventId);

                if (numTickets <= availableSeats)
                {
                    Console.WriteLine($"Seats are available. Requested: {numTickets}, Available: {availableSeats}");
                    return true;
                }
                else
                {
                    Console.WriteLine("Not enough seats available.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while checking availability: {ex.Message}");
                return false;
            }
        }
    }
}
