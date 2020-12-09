using System.Collections.Generic;
using System.Threading.Tasks;
using PeopleDB.Shared.Models;

namespace PeopleDB.Shared.Repository {
    
    public interface IVehicleRepository {
        
        List<Vehicle> GetAllVehicles();

        Task<Vehicle> GetVehicleById(uint? id);

        Task<Vehicle> CreateVehicle(Vehicle vehicle);

        void UpdateVehicle(Vehicle vehicle);

        Task<string> DeleteVehicle(uint? id);
    }
}