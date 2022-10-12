namespace Domain.Entities;

public class UserDetails
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid AddressId { get; set; }
    public Address Address { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }
    public string Pesel { get; set; }
    public string IdentityCardNumber { get; set; }
    public string? CompanyName { get; set; }
    public string? Nip { get; set; }
    public bool isDefault { get; set; }
}