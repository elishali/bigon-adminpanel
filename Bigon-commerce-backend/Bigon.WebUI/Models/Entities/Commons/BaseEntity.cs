namespace Bigon.WebUI.Models.Entities.Commons
{
    public abstract class BaseEntity<TKey> : AuditableEntity
        where TKey : struct
    {
        public TKey Id { get; set; }

    }
}
