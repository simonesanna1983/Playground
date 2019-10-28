using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdInfrastructure
    {
        public int StdInfrastructureId { get; set; }
        public int StdStadiumId { get; set; }
        public byte? TypeStadium { get; set; }
        public DateTime? DateConstruction { get; set; }
        public DateTime? DateRenovation { get; set; }
        public string RenovationSummary { get; set; }
        public bool? IsRetractableRoof { get; set; }
        public bool? IsGlt { get; set; }
        public bool? IsVarfacilities { get; set; }
        public bool? IsHawkEyeSupplier { get; set; }
        public bool? IsFifavartechnologyTestComplete { get; set; }
        public int? RefereeReviewAreaLocation { get; set; }
        public DateTime? DateOfTheTest { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
