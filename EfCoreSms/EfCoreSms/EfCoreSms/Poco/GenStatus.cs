using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class GenStatus
    {
        public string Status { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusNameAbbr { get; set; }
        public string StatusDescr { get; set; }
        public long? BitWiseCode { get; set; }
        public int? NumOrder { get; set; }
        public int? StatusIdparent { get; set; }
        public string StatusParent { get; set; }
        public int? TypeIdRelated { get; set; }
        public string TypeRelated { get; set; }
        public int? ChkStatus { get; set; }
    }
}
