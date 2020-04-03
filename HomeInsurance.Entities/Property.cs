using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.Entities
{
  public  class Property
    {
        public long PropertyId { get; set; }
        public string QouteId { get; set; }
        public long UserId { get; set; }
        public double MarketValue { get; set; }
        public int YearBuild { get; set; }
        public string SqureFootValue { get; set; }
        public string DwellingStyle { get; set; }
        public string RoofMaterial { get; set; }
        public string GarageType { get; set; }
        public int NumFullBaths { get; set; }
        public int NumHalfBaths { get; set; }
        public bool HasSwimmingPool { get; set; }

    }
}
