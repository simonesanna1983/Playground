using System;
using System.Collections.Generic;

namespace EfCoreSms.Poco
{
    public partial class StdContacts
    {
        public int StdContactsId { get; set; }
        public int StdStadiumId { get; set; }
        public byte TypeContact { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public virtual StdStadium StdStadium { get; set; }
    }
}
