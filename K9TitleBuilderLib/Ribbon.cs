using System;
using System.Collections.Generic;
using System.Text;

namespace K9TB
{
    public class Ribbon : Object
    {
        public string Description { get; set; }
        public List<MediaItem> MediaList { get; set; }

        public Ribbon()
        {
            MediaList = new List<MediaItem>();
        }
    }
}
