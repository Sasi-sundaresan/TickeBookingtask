using AssignmentTask.main;
using AssignmentTask.model;
using AssignmentTask.Repository;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;

namespace AssignmentTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 regionS
            //Console.WriteLine("Enter the available ticket");
            //int availableTicket = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the booking ticket");
            //int bookTicket = int.Parse(Console.ReadLine());



            //if (bookTicket < availableTicket)
            //{
            //    int remaining = availableTicket - bookTicket;
            //    Console.WriteLine($"remaining ticket is ::{remaining}");
            //    Console.WriteLine($"Ticket is available");
            //}
            //else
            //{
            //    Console.WriteLine("Ticket unavailable");
            //}

            #endregion

            //TASK 2: Nested Conditional Statements
            //Task 3: Looping
            #region Task2 and Task3

            //int dimond = 400;
            //int gold = 300;
            //int silver = 200;
            //int option;


            //do
            //{
            //    Console.WriteLine($"Enter your option \n1.Dimond\n2.Goald\n3.Silver\n4.Exit");
            //    option = int.Parse(Console.ReadLine());

            //    if (option == 4)
            //    {

            //        break;
            //    }

            //    Console.WriteLine("Enter the quantity");
            //    int quantity = int.Parse(Console.ReadLine());

            //    int total = 0;

            //    switch (option)
            //    {
            //        case 1:
            //            total = quantity * dimond;
            //            Console.WriteLine($"Total cost is :: {total}");
            //            break;

            //        case 2:
            //            total = quantity * gold;
            //            Console.WriteLine($"Total cost is :: {total}");
            //            break;

            //        case 3:
            //            total = quantity * silver;
            //            Console.WriteLine($"Total cost is :: {total}");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid option selected.");
            //            break;
            //    }

            //} while (option!=4);

            #endregion


            //TASK 4: Class & Object
            #region Event class

            //Event eventobj = new Event();


            //Console.WriteLine("Enter Event Name:");
            //eventobj.EventName = Console.ReadLine();

            //Console.WriteLine("Enter Event Date (yyyy-MM-dd):");
            //eventobj.EventDate = DateTime.Parse(Console.ReadLine());


            //Console.WriteLine("Enter Venue Name:");
            //eventobj.VenueName = Console.ReadLine();

            //Console.WriteLine("Enter Total Seats:");
            //eventobj.TotalSeats = int.Parse(Console.ReadLine());

            //// Initialize AvailableSeats to TotalSeats
            //eventobj.AvailableSeats = eventobj.TotalSeats;

            //Console.WriteLine("Enter Ticket Price:");
            //eventobj.TicketPrice = decimal.Parse(Console.ReadLine());



            //Console.WriteLine("\nEvent Created Successfully!\n");

            //// Display event details
            //eventobj.DisplayEventDetails();

            //// Book tickets
            //Console.WriteLine("Enter number of tickets to book:");
            //int ticketsToBook = int.Parse(Console.ReadLine());
            //eventobj.BookTickets(ticketsToBook);


            //// Cancel tickets
            //Console.WriteLine("Enter number of tickets to cancel:");
            //int ticketsToCancel = int.Parse(Console.ReadLine());
            //eventobj.CancelBooking(ticketsToCancel);


            //// Calculate total revenue
            //decimal totalRevenue = eventobj.CalculateTotalRevenue();
            //Console.WriteLine($"Total Revenue: {totalRevenue:C}");

            //// Get booked tickets
            //int bookedTickets = eventobj.GetBookedNoOfTickets();
            //Console.WriteLine($"Total Booked Tickets: {bookedTickets}");


            #endregion

            //Venue venueobj = new Venue();

            //Customer customerobj=new Customer();

            //Task 5: Inheritance and polymorphism



            //Movie movie = new Movie();  
            //Console.WriteLine("\nMovie Details:");
            //movie.DisplayMovieDetails();
            #region movie inheritance
            //Console.WriteLine("Enter Movie Name:");
            //string movieName = Console.ReadLine();

            //Console.WriteLine("Enter Movie Date (yyyy-MM-dd):");
            //DateTime movieDate = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Movie Time (HH:mm):");
            //TimeSpan movieTime = TimeSpan.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Venue Name:");
            //string venueName = Console.ReadLine();

            //Console.WriteLine("Enter Total Seats:");
            //int totalSeats = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Ticket Price:");
            //decimal ticketPrice = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Movie Type (Movie, Sports, Concert):");
            //Event.EventType type = Enum.Parse<Event.EventType>(Console.ReadLine(), true);

            //Console.WriteLine("Enter Movie Genre (e.g., Action, Comedy, Horror):");
            //string genre = Console.ReadLine();

            //Console.WriteLine("Enter Actor Name:");
            //string actorName = Console.ReadLine();

            //Console.WriteLine("Enter Actress Name:");
            //string actressName = Console.ReadLine();


            #endregion


            //Concert concert = new Concert();
            //Console.WriteLine("\nConcert Details:");
            //concert.DisplayConcertDetails();


            //Sports sports = new Sports();
            //Console.WriteLine("\nSports Event Details:");
            //sports.DisplaySportDetails();

            //main task





            TicketBookingmain ticketBookingApp = new TicketBookingmain();

           
            ticketBookingApp.ShowMenu();








        }

    }
}