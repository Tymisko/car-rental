using Domain.Common;

namespace Domain.Entities;

public class Feature : BaseAuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ICollection<Offer> Offers { get; set; }
}