using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentTask.model;
using AssignmentTask.Utility;

namespace AssignmentTask.Repository
{
    internal class Ticketbookingsystem :ITicketBooking
    {
        private string connectionString;

        public Ticketbookingsystem()
        {
            connectionString = DbConnUtil.GetConnectionString();
        }

        public bool CreateEvent(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, decimal ticketPrice, string eventType)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Event (event_name, event_date, event_time, venue_id, total_seats, available_seats, ticket_price, event_type) 
                         VALUES (@eventName, @eventDate, @eventTime, @venueId, @totalSeats, @availableSeats, @ticketPrice, @eventType)";
                SqlCommand command = new SqlCommand(query, connection);

                // Assuming you need to get the venue_id from the Venu table by venueName:
                string getVenueIdQuery = "SELECT venue_id FROM Venu WHERE venue_name = @venueName";
                SqlCommand venueIdCommand = new SqlCommand(getVenueIdQuery, connection);
                venueIdCommand.Parameters.AddWithValue("@venueName", venueName);

                connection.Open();
                int venueId = (int)venueIdCommand.ExecuteScalar(); // Retrieve the venue_id

                // Set the parameters for the event creation query
                command.Parameters.AddWithValue("@eventName", eventName);
                command.Parameters.AddWithValue("@eventDate", eventDate);
                command.Parameters.AddWithValue("@eventTime", eventTime);
                command.Parameters.AddWithValue("@venueId", venueId); // Use the retrieved venue_id
                command.Parameters.AddWithValue("@totalSeats", totalSeats);
                command.Parameters.AddWithValue("@availableSeats", totalSeats); // Initially, available seats = total seats
                command.Parameters.AddWithValue("@ticketPrice", ticketPrice);
                command.Parameters.AddWithValue("@eventType", eventType);

                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool BookTickets(int eventId, int numTickets)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string checkSeatsQuery = "SELECT available_seats FROM Event WHERE event_id = @eventId";
                SqlCommand checkCommand = new SqlCommand(checkSeatsQuery, connection);
                checkCommand.Parameters.AddWithValue("@eventId", eventId);

                connection.Open();
                int availableSeats = (int)checkCommand.ExecuteScalar();
                if (numTickets > availableSeats)
                {
                    Console.WriteLine("Not enough seats available.");
                    return false;
                }

                string bookQuery = @"UPDATE Event SET available_seats = available_seats - @numTickets WHERE event_id = @eventId";
                SqlCommand bookCommand = new SqlCommand(bookQuery, connection);
                bookCommand.Parameters.AddWithValue("@numTickets", numTickets);
                bookCommand.Parameters.AddWithValue("@eventId", eventId);

                int result = bookCommand.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool CancelTickets(int eventId, int numTickets)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string checkSeatsQuery = "SELECT total_seats - available_seats AS booked_tickets FROM Event WHERE event_id = @eventId";
                SqlCommand checkCommand = new SqlCommand(checkSeatsQuery, connection);
                checkCommand.Parameters.AddWithValue("@eventId", eventId);

                connection.Open();
                int bookedTickets = (int)checkCommand.ExecuteScalar();
                if (numTickets > bookedTickets)
                {
                    Console.WriteLine("Cannot cancel more tickets than booked.");
                    return false;
                }

                string cancelQuery = @"UPDATE Event SET available_seats = available_seats + @numTickets WHERE event_id = @eventId";
                SqlCommand cancelCommand = new SqlCommand(cancelQuery, connection);
                cancelCommand.Parameters.AddWithValue("@numTickets", numTickets);
                cancelCommand.Parameters.AddWithValue("@eventId", eventId);

                int result = cancelCommand.ExecuteNonQuery();
                return result > 0;
            }
        }

        public int GetAvailableSeats(int eventId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT available_seats FROM Event WHERE event_id = @eventId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@eventId", eventId);

                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public EventDetails GetEventDetails(int eventId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT event_name, event_date, event_time, venue_name, total_seats, available_seats, ticket_price, event_type, venue_id 
                         FROM event WHERE event_id = @eventId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@eventId", eventId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    
                    var eventDetails = new EventDetails(
                        eventName: reader["event_name"].ToString(),
                        eventDate: (DateTime)reader["event_date"],
                        eventTime: (TimeSpan)reader["event_time"],
                        venueName: GetVenueNameById((int)reader["venue_id"], connection),
                        totalSeats: (int)reader["total_seats"],
                        ticketPrice: (decimal)reader["ticket_price"],
                        type: (Event.EventType)Enum.Parse(typeof(Event.EventType), reader["event_type"].ToString())
                    );

              
                    reader.Close();

                    return eventDetails;
                }

                return null;
            }
        }



        private string GetVenueNameById(int venueId, SqlConnection connection)
        {
            string query = "SELECT venue_name FROM Venu WHERE venue_id = @venueId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@venueId", venueId);
            return (string)command.ExecuteScalar();
        }




    }
}
