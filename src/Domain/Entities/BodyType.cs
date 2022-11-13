using Domain.Common;

namespace Domain.Entities;

public class BodyType : BaseAuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Vehicle> Vehicles { get; set; }
}