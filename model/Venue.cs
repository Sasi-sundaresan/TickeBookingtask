
namespace AssignmentTask.model
{
    internal class Venue
    {
        public string VenueName { get; set; }
        public string Address { get; set; }

        // Default Constructor
        public Venue()
        {
            
        }

        // Parameterized Constructor
        public Venue(string venueName, string address)
        {
            VenueName = venueName;
            Address = address;
        }

        public void displayvenuedetails()
        {
            Console.WriteLine("Venue Details:");
            Console.WriteLine($"Venue Name::{VenueName}");
            Console.WriteLine($"Venue address::{Address}");
        }
    }
}
