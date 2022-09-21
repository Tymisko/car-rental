using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Reservation
{
    [Key] 
    public Guid Id { get; set; }
    public Guid ReservationStatusId { get; set; }
    public ReservationStatus ReservationStatus { get; set; }
    public Guid OfferId { get; set; }
    public Offer Offer { get; set; }
    public Guid UserDetailsId { get; set; }
    public UserDetails UserDetails { get; set; }
    public DateTime PickUpDate { get; set; }
    public DateTime? ReturnDate { get; set; }
}