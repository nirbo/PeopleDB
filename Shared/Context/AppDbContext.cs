using Microsoft.EntityFrameworkCore;
using PeopleDB.Shared.Models;

namespace PeopleDB.Shared.Context {
    public class AppDbContext : DbContext {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}