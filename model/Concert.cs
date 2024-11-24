

using System.Net.Mime;

namespace AssignmentTask.model
{
    internal class Concert : Event
    {
        public string artist { get; set; }
        public string concertType { get; set; }


        public Concert()
            : base() 
        {
           
        }

        // Parameterized constructor
        public Concert(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName,int totalSeats, decimal ticketPrice, EventType type,string artist, string concertType)
            : base(eventName, eventDate, eventTime, venueName, totalSeats, ticketPrice, type)
        {
            artist = artist;
            concertType = concertType;
        }

        public override void DisplayEventDetails()
        {
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate:yyyy-MM-dd}");
            Console.WriteLine($"Event Time: {EventTime}");
            Console.WriteLine($"Venue: {VenueName}");
            Console.WriteLine($"Total Seats: {TotalSeats}");
            Console.WriteLine($"Available Seats: {AvailableSeats}");
            Console.WriteLine($"Ticket Price: {TicketPrice}");
            Console.WriteLine($"Event Type: {Type}");
            Console.WriteLine($"Artist: {artist}");
            Console.WriteLine($"Concert Type: {concertType}");
        }
    }
}
