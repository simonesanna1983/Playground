using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdStadiumMeta
    {
        public int StdStadiumMetaId { get; set; }
        public int StdStadiumId { get; set; }
        public int? UserCreatedId { get; set; }
        public DateTime? DateCreatedUtc { get; set; }
        public int? UserUpdateId { get; set; }
        public DateTime? DateUpdateUtc { get; set; }
        public int? TypeSection { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
