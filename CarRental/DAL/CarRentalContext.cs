using System.Data.Entity;
using CarRental.Models;

namespace CarRental.DAL {
    internal class CarRentalContext : DbContext {
        public CarRentalContext() : base("CarRentalContext") {}

        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rent> Rents { get; set; }
    }
}