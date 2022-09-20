using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Reservation
{
    [Key] public Guid Id { get; set; }
    public DateTime PickUpDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    [ForeignKey(nameof(ReservationStatus))]
    public Guid StatusId { get; set; }

    [ForeignKey(nameof(Offer))] public Guid OfferId { get; set; }
    [ForeignKey(nameof(UserDetails))] public Guid UserDetailsId { get; set; }
}