using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace K9TB
{
    public class Award : Object
    {
        public Ribbon Ribbon { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Awarded On")]
        public DateTime Awarded { get; set; }

        public Award()
        {
            Awarded = DateTime.UtcNow;
        }
    }
}
