namespace Domain.Entities;

public class Model
{
    public Guid Id { get; set; }
    public Guid BrandId { get; set; }
    public Brand Brand { get; set; }
    public string Name { get; set; }
    public ICollection<Generation> Generations { get; set; }
}