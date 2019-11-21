using System;
using System.Collections.Generic;
using System.Text;

namespace K9TB
{
    public class Person : Object
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public List<MediaItem> MediaList { get; set; }

        public Person()
        {
            MediaList = new List<MediaItem>();
        }
    }
}
