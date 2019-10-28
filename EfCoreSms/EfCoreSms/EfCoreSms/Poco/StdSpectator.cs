using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdSpectator
    {
        public int StdSpectatorId { get; set; }
        public int StdStadiumId { get; set; }
        public int? UefaCapacity { get; set; }
        public int? NumCoveredSeats { get; set; }
        public int? NumUncoveredSeats { get; set; }
        public int? NumSeatsVisitingSector { get; set; }
        public bool? IsStandingAccommodation { get; set; }
        public int? NumStandingPlaces { get; set; }
        public int? NumSeatsWithoutBackrest { get; set; }
        public bool? IsDedicatedHospitalityVip { get; set; }
        public int? NumPartnersSeats { get; set; }
        public int? NumVvipSeats { get; set; }
        public int? NumPartnersSkyboxes { get; set; }
        public int? NumCorporateHospitalitySeats { get; set; }
        public int? NumParkingCars { get; set; }
        public int? NumParkingBuses { get; set; }
        public bool? IsDedicatedDisabilities { get; set; }
        public int? NumSeatsDisabilities { get; set; }
        public int? NumToiletsWomen { get; set; }
        public int? NumToiletsMen { get; set; }
        public int? NumUrinals { get; set; }
        public int? NumToiletDisabled { get; set; }
        public bool? IsControlRoomPitchView { get; set; }
        public bool? IsTurnstiles { get; set; }
        public int? TurnstilesFullHeight { get; set; }
        public int? TurnstilesHalfHeight { get; set; }
        public bool? IsElectronicAccess { get; set; }
        public bool? IsElectronicSystemTurnstiles { get; set; }
        public bool? IsCctvavailable { get; set; }
        public int? NumCamera { get; set; }
        public int? NumCameraOutside { get; set; }
        public bool? IsPublicAddressSystem { get; set; }
        public bool? HasFirstAidFacilities { get; set; }
        public int? NumberOfFirstAidFacilities { get; set; }
        public bool? AreFirstAidFacilitiesAccessible { get; set; }
        public int? ElectronicSystemTurnstilesControlType { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
