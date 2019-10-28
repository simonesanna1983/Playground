using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdAddCategoryLeisure
    {
        public int StdAddCategoryLeisureId { get; set; }
        public int StdStadiumId { get; set; }
        public bool? IsKidsClub { get; set; }
        public bool? IsClubMuseum { get; set; }
        public bool? IsHotel { get; set; }
        public int? NumOfStars { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
