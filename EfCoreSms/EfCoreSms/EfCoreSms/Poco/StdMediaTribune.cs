using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdMediaTribune
    {
        public int StdMediaTribuneId { get; set; }
        public int StdStadiumId { get; set; }
        public bool? IsSeatsDedicatedToMedia { get; set; }
        public int? NumSeatsWithDesks { get; set; }
        public int? NumSeatsWithoutDesk { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
