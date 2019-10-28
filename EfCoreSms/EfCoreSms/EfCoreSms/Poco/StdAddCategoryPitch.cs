using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdAddCategoryPitch
    {
        public int StdAddCategoryPitchId { get; set; }
        public int StdStadiumId { get; set; }
        public bool? IsPitchStripped { get; set; }
        public bool? IsPitchReseeded { get; set; }
        public byte? TypeTurf { get; set; }
        public int? NumLightingRigs { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
