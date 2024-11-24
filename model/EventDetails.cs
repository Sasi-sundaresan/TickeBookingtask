using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AssignmentTask.model.Event;

namespace AssignmentTask.model
{
    internal class EventDetails : Event
    {


        public EventDetails(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, decimal ticketPrice, EventType type)
           : base(eventName, eventDate, eventTime, venueName, totalSeats, ticketPrice, type)
        {
        }

        public override void DisplayEventDetails()
        {
            throw new NotImplementedException();
        }
    }
}
