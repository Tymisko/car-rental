using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;

public class Accessory
{
    [Key] 
    public Guid Id { get; set; }
    public Guid AccessoryCategoryId { get; set; }
    public AccessoryCategory AccessoryCategory { get; set; }
    public string Name { get; set; }
}