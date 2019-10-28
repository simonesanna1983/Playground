﻿using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class Dbversion
    {
        public int Id { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public int Revision { get; set; }
        public DateTime DateInsert { get; set; }
        public string Comment { get; set; }
    }
}
