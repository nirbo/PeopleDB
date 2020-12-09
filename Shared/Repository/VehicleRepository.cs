using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeopleDB.Shared.Context;
using PeopleDB.Shared.Models;

namespace PeopleDB.Shared.Repository {
    
    public class VehicleRepository : IVehicleRepository {

        private readonly AppDbContext _dbContext;

        public VehicleRepository(AppDbContext dbContext) {
            _dbContext = dbContext;
        }
        
        public List<Vehicle> GetAllVehicles() {
            return _dbContext.Vehicles.ToList();
        }

        public async Task<Vehicle> GetVehicleById(uint? id) {
            Vehicle vehicle = await _dbContext.Vehicles.FindAsync(id);
            if (vehicle == null) {
                return null;
            }
            
            return vehicle;
        }

        public async Task<Vehicle> CreateVehicle(Vehicle vehicle) {
            await _dbContext.Vehicles.AddAsync(vehicle);
            _dbContext.SaveChanges();
            return vehicle;
        }

        public void UpdateVehicle(Vehicle vehicle) {
            var local = _dbContext.Set<Vehicle>()
                .Local
                .FirstOrDefault(entry => entry.Id.Equals(vehicle.Id));

            if (local != null) {
                _dbContext.Entry(local).State = EntityState.Detached;
            }

            _dbContext.Entry(vehicle).State = EntityState.Modified;
            _dbContext.Vehicles.Update(vehicle);
            _dbContext.SaveChanges();
        }

        public async Task<string> DeleteVehicle(uint? id) {
            Vehicle vehicle = await GetVehicleById(id);
            if (vehicle == null) {
                return null;
            }

            _dbContext.Vehicles.Remove(vehicle);
            await _dbContext.SaveChangesAsync();
            return "Vehicle deleted successfully";
        }
    }
}