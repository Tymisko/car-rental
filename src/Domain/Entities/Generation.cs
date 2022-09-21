using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Generation
{
    [Key] 
    public Guid Id { get; set; }
    public Guid ModelId { get; set; }
    public Model Model { get; set; }
    public string Name { get; set; }
}