using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeopleDB.Shared.Models;
using PeopleDB.Shared.Repository;

namespace PeopleDB.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase {

        private readonly IVehicleRepository vehicleRepository;

        public VehicleController(IVehicleRepository _vehicleRepository) {
            vehicleRepository = _vehicleRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllVehicles() {
            List<Vehicle> allVehicles = vehicleRepository.GetAllVehicles();
            if (allVehicles.Count == 0) {
                return BadRequest("The DB is empty, please create a new vehicle entry");
            }

            return Ok(allVehicles);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetVehicleById(uint? id) {
            Vehicle vehicle = await vehicleRepository.GetVehicleById(id);
            if (vehicle == null) {
                return NotFound($"Vehicle entry with the Id {id} does not exist");
            }

            return Ok(vehicle);
        }
        
        [HttpPost("Create")]
        public async Task<IActionResult> CreateVehicle([FromBody] Vehicle vehicle) {
            List<Vehicle> allVehicles = vehicleRepository.GetAllVehicles()
                .Where(p => p.VehicleIdNumber == vehicle.VehicleIdNumber)
                .ToList();
            if (allVehicles.Count > 0) {
                return BadRequest("DuplicateVIN");
            }

            Vehicle createdVehicle = await vehicleRepository.CreateVehicle(vehicle);
            if (createdVehicle == null) {
                return BadRequest("An error has occurred, please try again");
            }
            
            return Ok(vehicle);
        }
        
        [HttpPut("Update")]
        public IActionResult UpdateVehicle([FromBody] Vehicle vehicle) {
            List<Vehicle> allVehicles = vehicleRepository.GetAllVehicles()
                .Where(p => p.VehicleIdNumber == vehicle.VehicleIdNumber)
                .ToList();
            if (allVehicles.Count > 0) {
                return BadRequest("DuplicateVIN");
            }
            
            if (vehicle == null) throw new ArgumentNullException(nameof(vehicle));
            vehicleRepository.UpdateVehicle(vehicle);
            
            return Ok("The vehicle was updated successfully");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteVehicle(uint? id) {
            string result = await vehicleRepository.DeleteVehicle(id);
            if (result == null) {
                return BadRequest("Unable to delete, this vehicle doesn't exist");
            }
            
            return Ok("The vehicle was deleted successfully");
        }
    }
}