using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdUser
    {
        public int StdUserId { get; set; }
        public int XedsPersonId { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte StatusUserPerson { get; set; }
        public int XedsOrganizationId { get; set; }
        public long TypeTeamBw { get; set; }
        public byte StadiumRole { get; set; }
        public bool IsTimeUser { get; set; }
        public bool IsConsultant { get; set; }
        public bool? IsOfficial { get; set; }
        public int? RealOrganizationId { get; set; }
        public bool? IsOfficialList { get; set; }
    }
}
