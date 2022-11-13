using Domain.Common;

namespace Domain.Entities;

public class Role : BaseAuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<User> Users { get; set; }
}