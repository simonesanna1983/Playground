using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdStadiumCompetition
    {
        public int Id { get; set; }
        public int StdStadiumId { get; set; }
        public int FcompCompetitionId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public byte TypeSource { get; set; }
        public int ConfederationId { get; set; }
        public string OrganizationShortName { get; set; }
        public int FcompCompetitionTypeId { get; set; }
        public string CompetitionTypeName { get; set; }
        public string CompetitionTypeAcronymName { get; set; }
        public string CompetitionTypeShortName { get; set; }
        public string CompetitionShortName { get; set; }
        public string CompetitionName { get; set; }
        public int SeasonId { get; set; }
        public string XmlRounds { get; set; }
        public string XmlTeams { get; set; }
    }
}
