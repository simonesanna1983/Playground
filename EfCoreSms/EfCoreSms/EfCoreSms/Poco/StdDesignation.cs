using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdDesignation
    {
        public int StdDesignationId { get; set; }
        public int StdInspectionId { get; set; }
        public int StatusValidation { get; set; }
        public int? XedsPersonId { get; set; }
        public int? FoffDesignationId { get; set; }

        public virtual StdInspection StdInspection { get; set; }
    }
}
