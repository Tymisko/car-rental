namespace Domain.Entities;

public class Vehicle
{
    public Guid Id { get; set; }
    public Guid GenerationId { get; set; }
    public Generation Generation { get; set; }
    public Guid FuelTypeId { get; set; }
    public FuelType FuelType { get; set; }
    public Guid GearboxTypeId { get; set; }
    public GearboxType GearboxType { get; set; }
    public Guid BodyTypeId { get; set; }
    public BodyType BodyType { get; set; }
    public ICollection<Accessory> Accessories { get; set; }
    public string Vin { get; set; }
    public string LicensePlate { get; set; }
    public int ProductionYear { get; set; }
    public float EngineCapacity { get; set; }
    public int HorsePowers { get; set; }
    public float AverageFuelConsumption { get; set; }
    public int SeatsNumber { get; set; }
    public string Color { set; get; }
}