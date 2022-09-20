using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Offer
{
    [Key] public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool Booked { get; set; }
    public bool IsActive { get; set; }
    [ForeignKey(nameof(Vehicle))] public Guid VehicleId { get; set; }
    [ForeignKey(nameof(OfferTermType))] public Guid OfferTermTypeId { get; set; }
    [ForeignKey(nameof(Feature))] public Guid[] AvailableFeatures { get; set; }
}