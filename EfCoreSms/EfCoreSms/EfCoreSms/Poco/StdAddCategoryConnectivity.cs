using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdAddCategoryConnectivity
    {
        public int StdAddCategoryConnectivityId { get; set; }
        public int StdStadiumId { get; set; }
        public bool? IsCashlessPayment { get; set; }
        public string CashlessPaymentName { get; set; }
        public bool? IsPaperlessTickets { get; set; }
        public string PaperlessTicketsName { get; set; }
        public bool? IsWifiConnectionStaff { get; set; }
        public bool? IsWifiConnexionrFans { get; set; }
        public bool? IsClubStadiumAppWebsite { get; set; }
        public string AppWebsiteDescription { get; set; }
        public bool? IsSocialMediaChannels { get; set; }
        public string SocialMediaDescription { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
