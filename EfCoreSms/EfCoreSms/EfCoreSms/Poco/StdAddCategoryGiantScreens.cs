using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdAddCategoryGiantScreens
    {
        public int StdAddCategoryGiantScreensId { get; set; }
        public int StdStadiumId { get; set; }
        public bool? IsGiantScreens { get; set; }
        public int? NumGiantScreens { get; set; }
        public string UseDescription { get; set; }
        public bool? IsLedperimeter { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
