using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Offer
{
    [Key] 
    public Guid Id { get; set; }
    public Guid VehicleId { get; set; }
    public Vehicle Vehicle { get; set; }
    public Guid OfferTermTypeId { get; set; }
    public OfferTermType OfferTermType { get; set; }
    public ICollection<Feature> Features { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool Booked { get; set; }
    public bool IsActive { get; set; }
}