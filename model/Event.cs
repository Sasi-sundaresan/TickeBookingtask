using AssignmentTask.Repository;
namespace AssignmentTask.model

{
    internal abstract class Event 
    {
   

        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan EventTime { get; set; }
        public string VenueName { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public decimal TicketPrice { get; set; }
        public EventType Type { get; set; }

        public enum EventType
        {
            Concert = 1,
            Sports = 2,
            Theater = 3
        }


     
        public Event()
        {


        }

       
       

        public Event(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, decimal ticketPrice, EventType type)
        {
            EventName = eventName;
            EventDate = eventDate;
            EventTime = eventTime;
            VenueName = venueName;
            TotalSeats = totalSeats;
            TicketPrice = ticketPrice;
            Type = type;
        }

      
        public abstract void DisplayEventDetails();


    }
}
