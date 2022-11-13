using Domain.Common;

namespace Domain.Entities;

public class PaymentType : BaseAuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Fee { get; set; }
    public ICollection<Payment> Payments { get; set; }
}