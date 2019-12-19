using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Poco
{
    public class MatchPoco
    {
        public string OfficialMatchName { get; set; }
        public string CompetitionName { get; set; }
        public string RoundName { get; set; }
        public DateTime? DateMatch { get; set; }
        public string DateMatchTimeString { get; set; }
        public string StadiumName { get; set; }
        public string VenueName { get; set; }
    }
}
