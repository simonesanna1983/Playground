using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdStadium
    {
        public StdStadium()
        {
            StdAddress = new HashSet<StdAddress>();
            StdAirportsRelated = new HashSet<StdAirportsRelated>();
            StdAssignment = new HashSet<StdAssignment>();
            StdCompletion = new HashSet<StdCompletion>();
            StdContacts = new HashSet<StdContacts>();
            StdInspection = new HashSet<StdInspection>();
            StdMediaFacilities = new HashSet<StdMediaFacilities>();
            StdOrganizationRelated = new HashSet<StdOrganizationRelated>();
            StdPitch = new HashSet<StdPitch>();
            StdStadiumLog = new HashSet<StdStadiumLog>();
        }

        public int StdStadiumId { get; set; }
        public string OfficialName { get; set; }
        public string SponsorName { get; set; }
        public string SpecialEventsName { get; set; }
        public string MediaName { get; set; }
        public string NormalizeName { get; set; }
        public int? VenueId { get; set; }
        public byte? TypeStadiumOwner { get; set; }
        public string StadiumOwnerFreeText { get; set; }
        public int? StatusOperational { get; set; }
        public string Notes { get; set; }
        public int? ProposedCategoryId { get; set; }
        public int? StdCategoryId { get; set; }
        public int? FcompStadiumId { get; set; }

        public virtual StdCategory StdCategory { get; set; }
        public virtual StdAddCategoryAccessibility StdAddCategoryAccessibility { get; set; }
        public virtual StdAddCategoryCatering StdAddCategoryCatering { get; set; }
        public virtual StdAddCategoryConnectivity StdAddCategoryConnectivity { get; set; }
        public virtual StdAddCategoryGiantScreens StdAddCategoryGiantScreens { get; set; }
        public virtual StdAddCategoryLeisure StdAddCategoryLeisure { get; set; }
        public virtual StdAddCategoryPitch StdAddCategoryPitch { get; set; }
        public virtual StdAddCategorySustainability StdAddCategorySustainability { get; set; }
        public virtual StdFloodlight StdFloodlight { get; set; }
        public virtual StdIndoorFacilities StdIndoorFacilities { get; set; }
        public virtual StdInfrastructure StdInfrastructure { get; set; }
        public virtual StdMediaCameraPlatforms StdMediaCameraPlatforms { get; set; }
        public virtual StdMediaTribune StdMediaTribune { get; set; }
        public virtual StdMediaTvCommentaryPositions StdMediaTvCommentaryPositions { get; set; }
        public virtual StdSafetyCertificate StdSafetyCertificate { get; set; }
        public virtual StdSpectator StdSpectator { get; set; }
        public virtual StdStadiumMeta StdStadiumMeta { get; set; }
        public virtual ICollection<StdAddress> StdAddress { get; set; }
        public virtual ICollection<StdAirportsRelated> StdAirportsRelated { get; set; }
        public virtual ICollection<StdAssignment> StdAssignment { get; set; }
        public virtual ICollection<StdCompletion> StdCompletion { get; set; }
        public virtual ICollection<StdContacts> StdContacts { get; set; }
        public virtual ICollection<StdInspection> StdInspection { get; set; }
        public virtual ICollection<StdMediaFacilities> StdMediaFacilities { get; set; }
        public virtual ICollection<StdOrganizationRelated> StdOrganizationRelated { get; set; }
        public virtual ICollection<StdPitch> StdPitch { get; set; }
        public virtual ICollection<StdStadiumLog> StdStadiumLog { get; set; }
    }
}
