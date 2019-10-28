using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdSafetyCertificate
    {
        public int StdSafetyCertificateId { get; set; }
        public int StdStadiumId { get; set; }
        public bool? IsCompliantLocalAuthorities { get; set; }
        public DateTime? DateOfIssue { get; set; }
        public DateTime? DateOfExpiry { get; set; }
        public string NafacilitiesDescription { get; set; }
        public bool? IsApprovedByPublicAuthorities { get; set; }
        public bool? IsMeetSafetySecurityRequirement { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
