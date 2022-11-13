using Domain.Common;

namespace Domain.Entities;

public class ReservationStatus : BaseAuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}