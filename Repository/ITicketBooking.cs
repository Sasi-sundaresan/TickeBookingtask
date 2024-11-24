using AssignmentTask.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask.Repository
{
    internal interface ITicketBooking
    {
        bool CreateEvent(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, decimal ticketPrice, string eventType);
        bool BookTickets(int eventId, int numTickets);
        bool CancelTickets(int eventId, int numTickets);
        int GetAvailableSeats(int eventId);
        EventDetails GetEventDetails(int eventId);

    }
}
