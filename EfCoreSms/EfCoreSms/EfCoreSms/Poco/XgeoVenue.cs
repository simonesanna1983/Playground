using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class XgeoVenue
    {
        public int Id { get; set; }
        public int XgeoVenueId { get; set; }
        public int XgeoCountryId { get; set; }
        public string VenueName { get; set; }
        public string DisplayName { get; set; }
        public string NormalizeName { get; set; }
        public string VenueCode { get; set; }
        public byte? StatusVenue { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}
