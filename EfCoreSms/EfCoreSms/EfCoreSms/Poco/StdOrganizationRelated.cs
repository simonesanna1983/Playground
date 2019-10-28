using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdOrganizationRelated
    {
        public int StdOrganizationRelatedId { get; set; }
        public int StdStadiumId { get; set; }
        public int XedsOrganizationId { get; set; }
        public bool? IsDefault { get; set; }

        public virtual StdStadium StdStadium { get; set; }
        public virtual XedsOrganization XedsOrganization { get; set; }
    }
}
