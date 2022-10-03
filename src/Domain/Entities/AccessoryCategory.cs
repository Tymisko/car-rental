namespace Domain.Entities;

public class AccessoryCategory
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Accessory> Accessories { get; set; }
}