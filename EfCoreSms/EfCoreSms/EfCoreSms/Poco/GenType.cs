using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class GenType
    {
        public string Type { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeNameAbbr { get; set; }
        public string TypeDescr { get; set; }
        public long? BitWiseCode { get; set; }
        public int? NumOrder { get; set; }
        public int? TypeIdparent { get; set; }
        public string TypeParent { get; set; }
        public int? ChkType { get; set; }
    }
}
