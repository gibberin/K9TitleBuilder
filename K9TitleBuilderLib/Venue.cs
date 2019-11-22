using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace K9TB
{
    public class Venue : Object
    {
        public string Description { get; set; }
        public string StreetAddr1 { get; set; }
        public string StreetAddr2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [DataType(DataType.PostalCode)]
        public string Zip { get; set; }
        public string Country { get; set; }
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:(###)-###-####}")]
        public string Phone { get; set; }
        public float Lat { get; set; }
        public float Long { get; set; }
        public string MapUrl { get; set; }
        public List<MediaItem> MediaList { get; set; }
        
        public Venue()
        {
            MediaList = new List<MediaItem>();
        }
    }
}
