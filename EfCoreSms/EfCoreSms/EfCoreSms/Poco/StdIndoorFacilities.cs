using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdIndoorFacilities
    {
        public int StdIndoorFacilitiesId { get; set; }
        public int StdStadiumId { get; set; }
        public int? HomeTeamNumSeat { get; set; }
        public int? HomeTeamNumShower { get; set; }
        public int? HomeTeamNumToilet { get; set; }
        public int? AwayTeamNumSeat { get; set; }
        public int? AwayTeamNumShower { get; set; }
        public int? AwayTeamNumToilet { get; set; }
        public int? RefereesNumSeat { get; set; }
        public int? RefereesNumShower { get; set; }
        public int? RefereesNumToilet { get; set; }
        public bool? IsDelegateRoom { get; set; }
        public bool? IsMedicalRoom { get; set; }
        public bool? IsDopingControlStation { get; set; }
        public bool? IsSeatedToilets { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
