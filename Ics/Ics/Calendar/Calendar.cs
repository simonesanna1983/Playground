using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;
using Ics.Helper;

namespace Ics.Calendar
{
    public class CalendarWrapper
    {

        public string Get => new CalendarSerializer().SerializeToString(Calendar);

        private Ical.Net.Calendar Calendar { get; }

        public CalendarWrapper()
        {
            Calendar = new Ical.Net.Calendar();
        }


        public void Add(CalendarEvent calendarEvent)
        {

            Calendar.Events.Add(calendarEvent);
        }

        public void AddRange(IEnumerable<CalendarEvent> calendarEvent)
        {
            Calendar.Events.AddRange(calendarEvent);

        }



    }
}
