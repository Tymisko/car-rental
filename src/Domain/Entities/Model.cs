using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Model
{
    [Key] 
    public Guid Id { get; set; }
    public Guid BrandId { get; set; }
    public Brand Brand { get; set; }
    public string Name { get; set; }
}