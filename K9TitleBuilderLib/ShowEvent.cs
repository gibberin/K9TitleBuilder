using System;
using System.Collections.Generic;

namespace K9TB
{
    public class ShowEvent : Object
    {
        public Venue Venue { get; set; }
        public List<MediaItem> MediaList { get; set; }

        public ShowEvent()
        {
            MediaList = new List<MediaItem>();
        }

        /// <summary>
        /// Allows the user to register for this event
        /// </summary>
        /// <returns>A registration confirmation</returns>
        public string Register()
        {
            // TODO: Initiate registration action for this event
            string confirmation = "";

            return confirmation;
        }
    }
}
