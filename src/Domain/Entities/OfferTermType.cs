using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class OfferTermType
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Value { get; set; }
}