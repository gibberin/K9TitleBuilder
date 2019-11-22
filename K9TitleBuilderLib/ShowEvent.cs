using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace K9TB
{
    public class ShowEvent : Object
    {
        public Venue Venue { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Start Date/Time")]
        public DateTime Start { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("End Date/Time")]
        public DateTime End { get; set; }
        [DisplayName("Media")]
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
