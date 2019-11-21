using System;
using System.Collections.Generic;
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
        public string ArmBand { get; set; }
        public string Description { get; set; }
        public ClassLevel ClassLevel { get; set; } // Novice/Intermediate/Advanced/Excellent/Master
        public string ExperienceLevel { get; set; } // A or B
        public DateTime Date { get; set; }
        public DateTime RingTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan RunTime { get; set; }
        public string Judge { get; set; }
        public string Handler { get; set; }
        public int ClassPlacing { get; set; }
        public bool Qualifying { get; set; }
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
