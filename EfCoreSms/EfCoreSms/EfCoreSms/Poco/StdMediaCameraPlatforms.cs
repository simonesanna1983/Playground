using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdMediaCameraPlatforms
    {
        public int StdMediaCameraPlatformsId { get; set; }
        public int StdStadiumId { get; set; }
        public bool? IsMain { get; set; }
        public decimal? MainWidth { get; set; }
        public decimal? MainDepth { get; set; }
        public bool? IsTwo16m { get; set; }
        public bool? IsOneReverseAngle { get; set; }
        public byte? TypeAngleCamera { get; set; }
        public bool? IsOneStandsBehindEachGoal { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
