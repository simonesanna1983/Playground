using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdMediaTvCommentaryPositions
    {
        public int StdMediaTvCommentaryPositionsId { get; set; }
        public int StdStadiumId { get; set; }
        public bool? IsTvcommentaryPositions { get; set; }
        public int? NumCommentaryPosition { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
