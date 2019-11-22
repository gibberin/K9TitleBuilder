using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace K9TB
{
    public class Breeder : Person
    {
        [DisplayName("Kennel")]
        public string KennelName { get; set; }
        public Venue Location { get; set; }
    }
}
