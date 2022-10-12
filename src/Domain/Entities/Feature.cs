namespace Domain.Entities;

public class Feature
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ICollection<Offer> Offers { get; set; }
}