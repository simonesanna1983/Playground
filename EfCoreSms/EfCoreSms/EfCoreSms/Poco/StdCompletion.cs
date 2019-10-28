using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdCompletion
    {
        public int StdCompletionId { get; set; }
        public int StdStadiumId { get; set; }
        public int? StdInspectionId { get; set; }
        public int? GeneralInfoTotal { get; set; }
        public int? GeneralInfoTotalRequired { get; set; }
        public int? GeneralInfoCompleted { get; set; }
        public int? GeneralInfoCompletedRequired { get; set; }
        public int? StaffAreasTotal { get; set; }
        public int? StaffAreasTotalRequired { get; set; }
        public int? StaffAreasCompleted { get; set; }
        public int? StaffAreasCompletedRequired { get; set; }
        public int? SpectatorTotal { get; set; }
        public int? SpectatorTotalRequired { get; set; }
        public int? SpectatorCompleted { get; set; }
        public int? SpectatorCompletedRequired { get; set; }
        public int? MediaAreasTotal { get; set; }
        public int? MediaAreasTotalRequired { get; set; }
        public int? MediaAreasCompleted { get; set; }
        public int? MediaAreasCompletedRequired { get; set; }
        public int? SafetyCertificateTotal { get; set; }
        public int? SafetyCertificateTotalRequired { get; set; }
        public int? SafetyCertificateCompleted { get; set; }
        public int? SafetyCertificateCompletedRequired { get; set; }
        public int? AdditionalCategoryTotal { get; set; }
        public int? AdditionalCategoryTotalRequired { get; set; }
        public int? AdditionalCategoryCompleted { get; set; }
        public int? AdditionalCategoryCompletedRequired { get; set; }
        public int? ConclusionsTotal { get; set; }
        public int? ConclusionsTotalRequired { get; set; }
        public int? ConclusionsCompleted { get; set; }
        public int? ConclusionsCompletedRequired { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
