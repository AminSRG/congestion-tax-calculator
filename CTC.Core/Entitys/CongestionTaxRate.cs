using CTC.Core.Base.Model;

namespace CTC.Core.Entitys
{
    // CongestionTaxRate class representing the tax rates for different time intervals
    public class CongestionTaxRate : BaseModel
    {
        public string TimeInterval { get; set; }
        public string Amount { get; set; }
    }
}