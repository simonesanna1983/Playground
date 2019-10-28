using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdCategory
    {
        public StdCategory()
        {
            StdStadium = new HashSet<StdStadium>();
        }

        public int StdCategoryId { get; set; }
        public string Name { get; set; }
        public int NumOrder { get; set; }
        public string Description { get; set; }
        public string NameAbbr { get; set; }
        public int? TypeStadium { get; set; }

        public virtual ICollection<StdStadium> StdStadium { get; set; }
    }
}
