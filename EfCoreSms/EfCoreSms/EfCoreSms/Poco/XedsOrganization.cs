using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class XedsOrganization
    {
        public XedsOrganization()
        {
            StdOrganizationRelated = new HashSet<StdOrganizationRelated>();
        }

        public int Id { get; set; }
        public int XedsOrganizationId { get; set; }
        public int TypeOrganization { get; set; }
        public string OrganizationName { get; set; }
        public string NormalizeName { get; set; }
        public string PrintName { get; set; }
        public int? XgeoCountryId { get; set; }
        public int StatusOrganization { get; set; }
        public string ShortName { get; set; }
        public int? ParentId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string FootballNormalizeName { get; set; }

        public virtual ICollection<StdOrganizationRelated> StdOrganizationRelated { get; set; }
    }
}
