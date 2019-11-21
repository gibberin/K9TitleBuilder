using System;
using System.Collections.Generic;
using System.Text;

namespace K9TB
{
    public class Title : Object
    {
        public List<Leg> QualifyingLegs { get; set; }
        public string Description {get;set;}
        public string Abbreviation { get; set; }
        public bool Postfix { get; set; }

        public Title()
        {
            QualifyingLegs = new List<Leg>();
        }
    }
}
