using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdFloodlight
    {
        public int StdFloodlightId { get; set; }
        public int StdStadiumId { get; set; }
        public decimal? HorizontalU1 { get; set; }
        public decimal? HorizontalU2 { get; set; }
        public decimal? VerticalU1 { get; set; }
        public decimal? VerticalU2 { get; set; }
        public int? LuxAvEh { get; set; }
        public int? LuxAvEv { get; set; }
        public bool? IsEmergencyPowerField { get; set; }
        public decimal? EmergencyPowerField { get; set; }
        public DateTime? DateLightingCertif { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
