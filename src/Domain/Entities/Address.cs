﻿using Domain.Common;

namespace Domain.Entities;

public class Address : BaseAuditableEntity
{
    public Guid Id { get; set; }
    public string Street { get; set; }
    public string Building { get; set; }
    public string? Apartment { get; set; }
    public string ZipCode { get; set; }
    public string City { get; set; }
}