using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Brand
{
    [Key] 
    public Guid Id { get; set; }
    public string Name { get; set; }
}