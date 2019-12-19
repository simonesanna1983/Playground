using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ical.Net;
using Ical.Net.DataTypes;

namespace Ics.Calendar
{
    public class CalendarItem
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsRecurrence { get; set; }
        public int? NumberOfRecurrence { get; set; }
        public FrequencyType? Frequency { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public GeographicLocation GeographicLocation { get; set; }

    }
}
