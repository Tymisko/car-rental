namespace Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public Guid RoleId { get; set; }
    public Role Role { get; set; }
    public string Password { get; set; }
    public bool EmailVerified { get; set; }
}