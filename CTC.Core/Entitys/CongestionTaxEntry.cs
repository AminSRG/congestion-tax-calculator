using CTC.Core.Base.Model;

namespace CTC.Core.Entitys
{
    public class CongestionTaxEntry : BaseModel
    {
        public DateTime EntryTime { get; set; }
        public Vehicle Vehicle { get; set; }
        public string TaxAmount { get; set; }
    }
}