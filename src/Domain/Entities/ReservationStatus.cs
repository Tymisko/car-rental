namespace Domain.Entities;

public class ReservationStatus
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}