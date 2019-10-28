using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdStadiumLog
    {
        public int StdStadiumLogId { get; set; }
        public int StdStadiumId { get; set; }
        public int? TypeSection { get; set; }
        public string Json { get; set; }
        public DateTime? Date { get; set; }
        public int? UserId { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
