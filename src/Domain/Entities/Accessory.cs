namespace Domain.Entities;

public class Accessory
{
    public Guid Id { get; set; }
    public Guid AccessoryCategoryId { get; set; }
    public AccessoryCategory AccessoryCategory { get; set; }
    public ICollection<Vehicle> Vehicles { get; set; }
    public string Name { get; set; }
}