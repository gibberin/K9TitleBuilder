using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace K9TB
{
    public class Title : Object
    {
        [DisplayName("Qualifying Legs")]
        public List<Leg> QualifyingLegs { get; set; }
        public string Description {get;set;}
        public string Abbreviation { get; set; }
        public bool Postfix { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Earned On")]
        public DateTime Achieved { get; set; }

        public Title()
        {
            QualifyingLegs = new List<Leg>();
        }
    }
}
