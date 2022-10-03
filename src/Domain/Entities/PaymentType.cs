namespace Domain.Entities;

public class PaymentType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Fee { get; set; }
    public ICollection<Payment> Payments { get; set; }
}