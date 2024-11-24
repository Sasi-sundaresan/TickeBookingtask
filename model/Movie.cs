

namespace AssignmentTask.model
{
    internal class Movie:Event
    {
        public string Genre { get; set; }
        public string ActorName { get; set; }
        public string ActressName { get; set; }

        // Constructor

        public Movie()
            :base()
        { 

        }

        public Movie(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, decimal ticketPrice, EventType type,string genre, string actorName, string actressName)
        : base(eventName, eventDate, eventTime, venueName, totalSeats, ticketPrice, type)
        {
            Genre = genre;
            ActorName = actorName;
            ActressName = actressName;
        }

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
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Actor Name: {ActorName}");
            Console.WriteLine($"Actress Name: {ActressName}");
        }
    }
}
