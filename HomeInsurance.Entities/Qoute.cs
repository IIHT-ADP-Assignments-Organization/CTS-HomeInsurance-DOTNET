using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.Entities
{
    public class Qoute
    {
        public string QouteId { get; set; }
        public string  Premium { get; set; }
        public string Dwelling { get; set; }
        public string DetachedStructure { get; set; }
        public string PersonalProperty { get; set; }
        public string AdditionalLivingproperty { get; set; }
        public double MedicalExpense { get; set; }
        public double Deductable { get; set; }
        public long UserId { get; set; }
    }
}
