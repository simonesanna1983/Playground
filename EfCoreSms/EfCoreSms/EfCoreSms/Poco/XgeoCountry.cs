using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class XgeoCountry
    {
        public int XgeoCountryId { get; set; }
        public int JoinedCountryId { get; set; }
        public byte IsCurrent { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string DisplayName { get; set; }
        public int StatusCountry { get; set; }
        public string NormalizeName { get; set; }
        public string Ioccode { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
