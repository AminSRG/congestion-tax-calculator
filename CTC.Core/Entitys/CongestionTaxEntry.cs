using CTC.Core.Base.Model;

namespace CTC.Core.Entitys
{
    // CongestionTaxEntry class representing a vehicle's entry or exit event
    public class CongestionTaxEntry : BaseModel
    {
        public DateTime EntryTime { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}