using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdInspection
    {
        public int StdInspectionId { get; set; }
        public int StdStadiumId { get; set; }
        public byte StatusInspection { get; set; }
        public DateTime? DateInspection { get; set; }
        public DateTime? DateApproved { get; set; }
        public bool? IsInfoFullyCompleted { get; set; }
        public string StadiumInformationComment { get; set; }
        public bool? IsFieldOfPlayCompliant { get; set; }
        public string InfrastructuresRegulationsComment { get; set; }
        public bool? IsHomeTeamDressingRoomCompliant { get; set; }
        public string HomeTeamComment { get; set; }
        public bool? IsAwayTeamDressingRoomCompliant { get; set; }
        public string AwayTeamComment { get; set; }
        public bool? IsRefereesDressingRoomCompliant { get; set; }
        public string RefereesComment { get; set; }
        public bool? IsDelegateRoomCompliant { get; set; }
        public string DelegateRoomComment { get; set; }
        public bool? IsEmergencyMedicalRoomCompliant { get; set; }
        public string EmergencyMedicalRoomComment { get; set; }
        public bool? IsDopingControlStationCompliant { get; set; }
        public string DopingControlStationComment { get; set; }
        public bool? IsFloodlightingCompliant { get; set; }
        public string FloodlightingComment { get; set; }
        public string AreasPlayersOfficialsComment { get; set; }
        public bool? IsCapacityInformationCompliant { get; set; }
        public string CapacityInformationComment { get; set; }
        public bool? IsSpectatorFacilitiesCompliant { get; set; }
        public string SpectatorFacilitiesComment { get; set; }
        public bool? IsEquipmentsCompliant { get; set; }
        public string EquipmentsComment { get; set; }
        public string SpectatorComment { get; set; }
        public bool? IsMediaFacilitiesCompliant { get; set; }
        public string MediaFacilitiesComment { get; set; }
        public bool? IsMediaTribuneUefacompliant { get; set; }
        public string MediaTribuneComment { get; set; }
        public bool? IsTvcommentaryPositionsCompliant { get; set; }
        public string CommentaryPositionComment { get; set; }
        public bool? IsCameraPlatformsCompliant { get; set; }
        public string CameraPlatformsComment { get; set; }
        public string ConclusionGeneralInfoComment { get; set; }
        public string ConclusionStadiumOverallConditionComment { get; set; }
        public string ConclusionAccessAccommodationComment { get; set; }
        public string ConclusionSafetySecurityComment { get; set; }
        public byte? ConclusionStadiumAssessment { get; set; }
        public int? UserCreatedId { get; set; }
        public DateTime? DateCreatedUtc { get; set; }
        public int? UserUpdateId { get; set; }
        public DateTime? DateUpdateUtc { get; set; }
        public string StadiumInformationShortSummary { get; set; }
        public string TvmediaFacilitiesShortSummary { get; set; }

        public virtual StdStadium StdStadium { get; set; }
        public virtual StdDesignation StdDesignation { get; set; }
    }
}
