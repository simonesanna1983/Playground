using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdAddCategoryAccessibility
    {
        public int StdAddCategoryAccessibilityId { get; set; }
        public int StdStadiumId { get; set; }
        public bool? IsCloseHighway { get; set; }
        public int? NumHighways { get; set; }
        public bool? IsConnectionPublicTransp { get; set; }
        public int? NumSubwayLines { get; set; }
        public int? NumSubwayStations { get; set; }
        public int? NumBusesLines { get; set; }
        public int? NumBusesStations { get; set; }
        public int? NumTrainLines { get; set; }
        public int? NumTrainStations { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
