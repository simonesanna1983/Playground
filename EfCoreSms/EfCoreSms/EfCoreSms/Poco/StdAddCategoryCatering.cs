using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdAddCategoryCatering
    {
        public int StdAddCategoryCateringId { get; set; }
        public int StdStadiumId { get; set; }
        public bool? IsRestaurantsBars { get; set; }
        public int? NumRestaurant { get; set; }
        public int? NumBar { get; set; }
        public bool? IsOpenMatchday { get; set; }
        public bool? IsOpenDuringMatch { get; set; }
        public bool? IsOpenGeneralPublic { get; set; }
        public bool? IsMerchandisingOutlet { get; set; }
        public int? NumMerchandisingOutlets { get; set; }
        public bool? IsMall { get; set; }
        public string KindShopsDescription { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
