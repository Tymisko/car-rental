using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Payment
{
    [Key]
    public Guid Id { get; set; }

    public DateTime Date { get; set; }
    [ForeignKey(nameof(Reservation))]
    public Guid ReservationId { get; set; }
    [ForeignKey(nameof(PaymentType))]
    public Guid PaymentTypeId { get; set; }
}