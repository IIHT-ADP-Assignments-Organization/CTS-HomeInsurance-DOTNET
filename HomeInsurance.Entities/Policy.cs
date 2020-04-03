using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.Entities
{
  public class Policy
    {
        public string PolicyKey { get; set; }
        public string QuoteId { get; set; }
        public DateTime PolicyEffectiveDate { get; set; }
        public DateTime PolicyEndDate { get; set; }
        public string PolicyTermPeriod { get; set; }
        public string PolicyTerm { get; set; }
    }
}
