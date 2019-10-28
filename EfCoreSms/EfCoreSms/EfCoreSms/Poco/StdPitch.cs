using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdPitch
    {
        public int StdPitchId { get; set; }
        public int StdStadiumId { get; set; }
        public byte? TypePitch { get; set; }
        public int? TypeFifacategory { get; set; }
        public DateTime? DateExpiry { get; set; }
        public decimal? DimPitchLength { get; set; }
        public decimal? DimPitchWidth { get; set; }
        public bool? IsHeating { get; set; }
        public bool? IsCover { get; set; }
        public bool? IsLightingSystem { get; set; }
        public bool? IsElectricHeatingSystem { get; set; }
        public bool? IsUndersoilHeating { get; set; }
        public bool? IsSubairSystem { get; set; }
        public bool? IsIrrigationSystem { get; set; }
        public string IrrigationSystemDescription { get; set; }
        public bool? IsProtectionFrost { get; set; }
        public string ProtectionFrostDescription { get; set; }
        public byte? TypeLocationWarmUp { get; set; }
        public bool? Is2FullyCoveredBenches { get; set; }
        public byte? CapacityRightBench { get; set; }
        public byte? CapacityLeftBench { get; set; }
        public bool? IsPos4Off { get; set; }
        public bool? IsGoalCompliantIfab { get; set; }
        public bool? IsFlagpoles { get; set; }
        public int? CapacityFlagpoles { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
