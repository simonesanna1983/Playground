using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdAttachment
    {
        public int StdAttachmentId { get; set; }
        public int RelatedId { get; set; }
        public int TypeRelated { get; set; }
        public int TypeSection { get; set; }
        public int TypeAttachment { get; set; }
        public string FileName { get; set; }
        public int? Size { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? UserId { get; set; }
        public Guid Guid { get; set; }
        public byte RepositoryType { get; set; }
        public string FameUrl { get; set; }
        public bool? Deleted { get; set; }
        public bool? HasThumb { get; set; }
    }
}
