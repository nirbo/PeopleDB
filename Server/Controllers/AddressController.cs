using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeopleDB.Shared.Models;
using PeopleDB.Shared.Repository;

namespace PeopleDB.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase {

        private readonly IAddressRepository addressRepository;

        public AddressController(IAddressRepository _addressRepository) {
            addressRepository = _addressRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllAddresses() {
            List<Address> allAddresses = addressRepository.GetAllAddresses();
            if (allAddresses.Count == 0) {
                return BadRequest("The DB is empty, please create a new address entry");
            }

            return Ok(allAddresses);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAddressById(uint? id) {
            Address address = await addressRepository.GetAddressById(id);
            if (address == null) {
                return NotFound($"Address entry with the Id {id} does not exist");
            }

            return Ok(address);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateAddress([FromBody] Address address) {
            Address createdAddress = await addressRepository.CreateAddress(address);
            if (createdAddress == null) {
                return BadRequest("An error has occurred, please try again");
            }

            return Ok(address);
        }
        
        [HttpPut("Update")]
        public IActionResult UpdateAddress([FromBody] Address address) {
            if (address == null) throw new ArgumentNullException(nameof(address));
            addressRepository.UpdateAddress(address);
            return Ok("The address was updated successfully");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteAddress(uint? id) {
            string result = await addressRepository.DeleteAddress(id);
            if (result == null) {
                return BadRequest("Unable to delete, this address doesn't exist");
            }
            
            return Ok("The address was deleted successfully");
        }
    }
}