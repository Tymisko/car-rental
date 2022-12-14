namespace Domain.Entities;

public class FuelType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Vehicle> Vehicles { get; set; }
}