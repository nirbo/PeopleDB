using Microsoft.EntityFrameworkCore;
using PeopleDB.Shared.Models;

namespace PeopleDB.Shared.Context {
    public class AppDbContext : DbContext {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Person>()
                .HasIndex(p => p.sin)
                .IsUnique();

            modelBuilder.Entity<Pet>()
                .HasIndex(p => p.PetRegistrationNumber)
                .IsUnique();
            
            modelBuilder.Entity<Vehicle>()
                .HasIndex(v => v.VehicleIdNumber)
                .IsUnique();
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}