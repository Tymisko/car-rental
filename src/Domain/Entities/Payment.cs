using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Payment
{
    [Key]
    public Guid Id { get; set; }
    public Guid ReservationId { get; set; }
    public Reservation Reservation { get; set; }
    public Guid PaymentTypeId { get; set; }
    public PaymentType PaymentType { get; set; }
    public DateTime Date { get; set; }
}