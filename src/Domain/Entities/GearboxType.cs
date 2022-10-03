namespace Domain.Entities;

public class GearboxType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Vehicle> Vehicles { get; set; }
}