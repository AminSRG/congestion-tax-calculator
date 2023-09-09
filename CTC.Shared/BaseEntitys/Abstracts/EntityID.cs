namespace CTC.Shared.BaseEntitys.Abstracts
{
    public abstract class EntityID : BaseEntity, Interfaces.IEntityID
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
    }
}
