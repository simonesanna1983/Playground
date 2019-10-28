using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdAssignment
    {
        public int StdAssignmentId { get; set; }
        public int StdStadiumId { get; set; }
        public int XedsPersonId { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
