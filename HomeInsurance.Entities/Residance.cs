using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.Entities
{
  public  class Residance
    {
        public string QuoteId { get; set; }
        public string ResidanceType { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public string ResidanceUse { get; set; }
        public string  UserName { get; set; }
}
}
