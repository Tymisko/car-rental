using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class User
{
    [Key]
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool EmailVerified { get; set; }
    [ForeignKey(nameof(Role))]
    public Guid RoleId { get; set; }
}