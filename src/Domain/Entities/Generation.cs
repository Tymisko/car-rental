using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Generation
{
    [Key] public Guid Id { get; set; }
    [ForeignKey(nameof(Model))] public Guid ModelId { get; set; }
    public string Name { get; set; }
}