using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace K9TB
{
    public enum ClassLevel
    {
        Novice,
        Intermediate,
        Advanced,
        Excellent,
        Master
    }

    public class Run : Object
    {

        public float Score { get; set; }
        public string Ring { get; set; }
        [DisplayName("Arm Band")]
        public string ArmBand { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public float Cost { get; set; }
        [DisplayName("Class Level")]
        public ClassLevel ClassLevel { get; set; } // Novice/Intermediate/Advanced/Excellent/Master
        [DisplayName("Experience Level")]
        public string ExperienceLevel { get; set; } // A or B
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Run Date")]
        public DateTime Date { get; set; }
        [DisplayName("Ring Time")]
        public DateTime RingTime { get; set; }
        [DisplayName("Start Time")]
        public DateTime StartTime { get; set; }
        [DisplayName("End Time")]
        public DateTime EndTime { get; set; }
        [DisplayName("Run Length (s)")]
        public TimeSpan RunTime { get; set; }
        public Person Judge { get; set; }
        public Person Handler { get; set; }
        [DisplayName("Rank in Class")]
        public int ClassPlacing { get; set; }
        public bool Qualifying { get; set; }
        [DisplayName("Show")]
        public ShowEvent ShowEvent { get; set; }
        public string Notes { get; set; }
        public List<MediaItem> MediaList { get; set; }

        public Run()
        {
            MediaList = new List<MediaItem>();
        }

        public float Points()
        {
            // Score schedule is:
            //  100         - 5
            //  99          - 4
            //  98          - 3
            //  97          - 2
            //  96 thru 91  - 1

            if(Score < 91)
            {
                return 0;
            }

            if(Score < 97)
            {
                return 1;
            }

            return 5 - (100 - Score);
        }
    }
}
