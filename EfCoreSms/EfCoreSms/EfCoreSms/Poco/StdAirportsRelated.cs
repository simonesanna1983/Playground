using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdAirportsRelated
    {
        public int StdAirportsRelatedId { get; set; }
        public int XgeoPlaceId { get; set; }
        public int StdStadiumId { get; set; }
        public string PlaceName { get; set; }
        public string ShortName { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
