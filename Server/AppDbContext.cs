using Microsoft.EntityFrameworkCore;
using PeopleDB.Shared.Entities;

namespace PeopleDB.Server {
    public class AppDbContext : DbContext {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}