using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdAddress
    {
        public int StdAddressId { get; set; }
        public int StdStadiumId { get; set; }
        public int? CountryId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Pobox { get; set; }
        public string PostCode { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
