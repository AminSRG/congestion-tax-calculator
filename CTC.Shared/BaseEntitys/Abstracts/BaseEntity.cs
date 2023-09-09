using CTC.Shared.BaseEntitys.Interfaces;

namespace CTC.Shared.BaseEntitys.Abstracts
{
    public abstract class BaseEntity : IBaseEntitys
    {
        public DateTime InsertDateTime { get; set; } = DateTime.Now;
        public DateTime UpdateDateTime { get; set; } = DateTime.Now;
    }
}
