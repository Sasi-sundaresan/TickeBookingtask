
namespace AssignmentTask.model
{
    internal class Booking : Event
    {
        public int NumberOfTickets { get; private set; }
        public decimal TotalCost { get; private set; }

        // Constructor
        public Booking(string eventName, DateTime eventDate, TimeSpan eventTime, int venueid, int totalSeats, decimal ticketPrice, string type)
        : base(eventName, eventDate, eventTime, venueid, totalSeats, ticketPrice, type)
        {

        }

  

       
        public void CalculateBookingCost(int numTickets)
        {
            TotalCost = numTickets * TicketPrice;
        }

        public void BookTickets(int numTickets)
        {
            if (numTickets <= AvailableSeats)
            {
                AvailableSeats =AvailableSeats- numTickets;
                NumberOfTickets =NumberOfTickets+ numTickets;
                CalculateBookingCost(numTickets);
                Console.WriteLine($"Successfully booked {numTickets} tickets for {EventName}.");
            }
            else
            {
                Console.WriteLine("Not enough seats available for booking.");
            }
        }

        public void CancelBooking(int numTickets)
        {
            if (numTickets <= NumberOfTickets)
            {
                AvailableSeats =AvailableSeats+ numTickets;
                NumberOfTickets =NumberOfTickets- numTickets;
                Console.WriteLine($"Successfully canceled {numTickets} tickets for {EventName}.");
            }
            else
            {
                Console.WriteLine("Cannot cancel more tickets than booked.");
            }
        }

        public int GetAvailableNoOfTickets()
        {
            return AvailableSeats;
        }

      

        public override void DisplayEventDetails()
        {
            throw new NotImplementedException();
        }
    }
}
