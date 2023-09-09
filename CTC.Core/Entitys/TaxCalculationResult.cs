using CTC.Core.Base.Model;

namespace CTC.Core.Entitys
{
    // TaxCalculationResult class representing the result of tax calculation for a vehicle
    public class TaxCalculationResult : BaseModel
    {
        public CongestionTaxEntry Entry { get; set; }
        public bool IsExempt { get; set; }
    }
}