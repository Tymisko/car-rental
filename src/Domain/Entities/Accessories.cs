using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Accessories
{
    [Key] public Guid Id { get; set; }
    public string Name { get; set; }

    [ForeignKey(nameof(AccessoryCategory))]
    public Guid CategoryId { get; set; }
}