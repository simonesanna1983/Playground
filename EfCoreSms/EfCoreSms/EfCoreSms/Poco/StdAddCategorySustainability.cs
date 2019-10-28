using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdAddCategorySustainability
    {
        public int StdAddCategorySustainabilityId { get; set; }
        public int StdStadiumId { get; set; }
        public bool? IsStorageWater { get; set; }
        public string StorageWaterDescription { get; set; }
        public bool? IsWaterSavingTechnology { get; set; }
        public bool? IsEnergySavingPolicy { get; set; }
        public bool? IsSolarPanels { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
