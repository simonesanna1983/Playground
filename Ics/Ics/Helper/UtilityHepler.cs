using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ical.Net;
using Ical.Net.DataTypes;
using Repository.Poco;

namespace Ics.Helper
{
    public static class UtilityHepler
    {

        public static List<RecurrencePattern> ListOfRecurrence(FrequencyType? frequency, int? numberOfRecurrence)
        {
            if (!frequency.HasValue)
            {
                throw new Exception("Frequency must not be null");
            }

            if (!numberOfRecurrence.HasValue)
            {
                throw new Exception("Number of Recurrence must not be null");
            }

            var rrule = new RecurrencePattern(frequency.Value, 1) { Count = numberOfRecurrence.Value };
            return new List<RecurrencePattern> { rrule };

        }


        public static DateTime ToDateMatch(this DateTime dateMatch, string kickOffTime)
        {

            dateMatch = dateMatch + kickOffTime.ToTimeSpan();

            return dateMatch;

        }


        public static int ToInt(this string time)
        {
            return Convert.ToInt32(time);
        }


        public static TimeSpan ToTimeSpan(this string kickOffTime)
        {
            if ((!string.IsNullOrEmpty(kickOffTime)) && kickOffTime != "00:00")
            {
                return new TimeSpan(kickOffTime.Substring(0, 2).ToInt(), kickOffTime.Substring(3, 2).ToInt(), 0);
            }
            return new TimeSpan(9, 0, 0);

        }


        public static string ToDescription(this MatchPoco matchPoco)
        {
            string description = "";

            if (!string.IsNullOrEmpty(matchPoco.StadiumName))
            {
                description += $"{matchPoco.StadiumName}";
                if (!string.IsNullOrEmpty(matchPoco.VenueName))
                {
                    description += $",{matchPoco.VenueName}";

                }
                description += $"<br/><br/>";

            }


            if (!string.IsNullOrEmpty(matchPoco.CompetitionName))
            {
                description += $"{matchPoco.CompetitionName}<br/>";
            }

            if (!string.IsNullOrEmpty(matchPoco.RoundName))
            {
                description += $"{matchPoco.RoundName}<br/>";
            }

            description += $"<br/><b>{matchPoco.OfficialMatchName}</b>";

            return description;




        }

    }
}
