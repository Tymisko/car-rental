using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
	DbSet<Accessory> Accessories { get; }
	DbSet<AccessoryCategory> AccessoryCategories { get; }
	DbSet<Address> Addresses { get; }
	DbSet<BodyType> BodyTypes { get; }
	DbSet<Brand> Brands { get; }
	DbSet<Feature> Features { get; }
	DbSet<FuelType> FuelTypes { get; }
	DbSet<GearboxType> GearboxTypes { get; }
	DbSet<Generation> Generations { get; }
	DbSet<Model> Models { get; }
	DbSet<Offer> Offers { get; }
	DbSet<OfferTermType> OfferTermTypes { get; }
	DbSet<Payment> Payments { get; }
	DbSet<PaymentType> PaymentTypes { get; }
	DbSet<Reservation> Reservations { get; }
	DbSet<ReservationStatus> ReservationStatuses { get; }
	DbSet<Role> Roles { get; }
	DbSet<User> Users { get; }
	DbSet<UserDetails> UserDetails { get; }
	DbSet<Vehicle> Vehicles { get; }

	Task<int> SaveChangesASync(CancellationToken cancellationToken);
}