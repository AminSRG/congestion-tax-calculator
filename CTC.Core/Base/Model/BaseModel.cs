namespace CTC.Core.Base.Model
{
    public abstract class BaseModel : CTC.Shared.BaseEntitys.Abstracts.EntityID
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}