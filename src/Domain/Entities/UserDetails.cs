﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class UserDetails
{
    [Key]
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }
    public string Pesel { get; set; }
    public string IdentityCardNumber { get; set; }
    public string? CompanyName { get; set; }
    public string? NIP { get; set; }
    [ForeignKey(nameof(Address))]
    public Guid AddressId { get; set; }
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
}