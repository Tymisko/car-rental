using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class AccessoryCategory
{
    [Key] public Guid Id { get; set; }
    public string Name { get; set; }
}