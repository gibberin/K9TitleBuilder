using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace K9TB
{
    public enum PrizeType
    {
        Money,
        Gift
    }

    public class Prize
    {
        public PrizeType Type { get; set; }
        [DataType(DataType.Currency)]
        public float Amount { get; set; }
    }
}
