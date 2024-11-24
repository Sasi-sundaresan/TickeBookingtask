using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask.model
{
    internal class Sports:Event
    {
        public string SportName { get; set; }
        public string TeamsName { get; set; } 

       
        public Sports()
            : base() 
        {
       
        }

       
        public Sports(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, decimal ticketPrice, EventType type,string sportName, string teamsName)
            : base(eventName, eventDate, eventTime, venueName, totalSeats, ticketPrice, type)
        {
            SportName = sportName;
            TeamsName = teamsName;
        }

        // Method to display sport details
        public override void DisplayEventDetails()
        {
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate:yyyy-MM-dd}");
            Console.WriteLine($"Event Time: {EventTime}");
            Console.WriteLine($"Venue: {VenueName}");
            Console.WriteLine($"Total Seats: {TotalSeats}");
            Console.WriteLine($"Available Seats: {AvailableSeats}");
            Console.WriteLine($"Ticket Price: {TicketPrice:C}");
            Console.WriteLine($"Event Type: {Type}");
            Console.WriteLine($"Sport Name: {SportName}");
            Console.WriteLine($"Teams: {TeamsName}");
        }
    }
}
