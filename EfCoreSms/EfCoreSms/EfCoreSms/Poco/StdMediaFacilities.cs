using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdMediaFacilities
    {
        public int StdMediaFacilitiesId { get; set; }
        public int StdStadiumId { get; set; }
        public bool? IsMediaWorkingArea { get; set; }
        public int? CapacityMediaWorkingArea { get; set; }
        public bool? IsPhotographerWorkingArea { get; set; }
        public int? CapacityPhotographer { get; set; }
        public bool? IsPressConferenceRoom { get; set; }
        public int? CapacityPressConference { get; set; }
        public bool? IsMixedZone { get; set; }
        public int? CapacityMixedZone { get; set; }
        public bool? IsIndoorTvstudios { get; set; }
        public int? CapacityIndoorTvstudios { get; set; }
        public bool? IsPitchViewTvstudios { get; set; }
        public int? CapacityViewTvstudios { get; set; }
        public bool? IsTvcompound { get; set; }
        public decimal? DimTvcompound { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
