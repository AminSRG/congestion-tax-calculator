using CTC.Core.Base.Model;

namespace CTC.Core.Entitys
{
    public class TaxCalculationResult : BaseModel
    {
        public CongestionTaxEntry Entry { get; set; }
        public bool IsExempt { get; set; }
    }
}