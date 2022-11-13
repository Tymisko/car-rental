﻿using Domain.Common;

namespace Domain.Entities;

public class Generation : BaseAuditableEntity
{
    public Guid Id { get; set; }
    public Guid ModelId { get; set; }
    public Model Model { get; set; }
    public string Name { get; set; }
    public ICollection<Vehicle> Vehicles { get; set; }
}