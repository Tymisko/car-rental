using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Vehicle
{
    [Key] public Guid Id { get; set; }
    public int ProductionYear { get; set; }
    public string Color { get; set; }
    public float EngineCapacity { get; set; }
    public float AverageFuelConsumption { get; set; }
    public int SeatsNumber { get; set; }
    public int HorsePowers { get; set; }
    public string Vin { get; set; }
    public string LicensePlate { get; set; }
    [ForeignKey(nameof(FuelType))] public Guid FuelTypeId { get; set; }
    [ForeignKey(nameof(BodyType))] public Guid BodyTypeId { get; set; }
    [ForeignKey(nameof(GearboxType))] public Guid GearboxTypeId { get; set; }
    [ForeignKey(nameof(Generation))] public Guid GenerationId { get; set; }
    [ForeignKey(nameof(Accessories))] public Guid[] AccessoriesIds { get; set; }
}