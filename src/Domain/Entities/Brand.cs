using Domain.Common;

namespace Domain.Entities;

public class Brand : BaseAuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Model> Models { get; set; }
}