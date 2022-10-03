namespace Domain.Entities;

public class OfferTermType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Offer> Offers { get; set; }
}