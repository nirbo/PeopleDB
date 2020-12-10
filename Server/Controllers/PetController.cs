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
    public class PetController : ControllerBase {

        private readonly IPetRepository petRepository;

        public PetController(IPetRepository _petRepository) {
            petRepository = _petRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllPets() {
            List<Pet> allPets = petRepository.GetAllPets();
            if (allPets.Count == 0) {
                return BadRequest("The DB is empty, please create a new pet entry");
            }

            return Ok(allPets);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetPetById(uint? id) {
            Pet pet = await petRepository.GetPetById(id);
            if (pet == null) {
                return NotFound($"Pet entry with the Id {id} does not exist");
            }

            return Ok(pet);
        }
        
        [HttpPost("Create/{id}")]
        public async Task<IActionResult> CreatePet([FromBody] Pet pet) {
            List<Pet> allPets = petRepository.GetAllPets()
                .Where(p => p.PetRegistrationNumber == pet.PetRegistrationNumber)
                .ToList();
            if (allPets.Count > 0) {
                return BadRequest("DuplicatePetRegNumber");
            }

            Pet createdPet = await petRepository.CreatePet(pet);
            if (createdPet == null) {
                return BadRequest("An error has occurred, please try again");
            }
            
            return Ok(pet);
        }
        
        [HttpPut("Update")]
        public IActionResult UpdatePet([FromBody] Pet pet) {
            List<Pet> allPets = petRepository.GetAllPets()
                .Where(p => p.PetRegistrationNumber == pet.PetRegistrationNumber)
                .ToList();
            if (allPets.Count > 0) {
                return BadRequest("DuplicatePetRegNumber");
            }
            
            if (pet == null) throw new ArgumentNullException(nameof(pet));
            petRepository.UpdatePet(pet);
            
            return Ok("The pet was updated successfully");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeletePet(uint? id) {
            string result = await petRepository.DeletePet(id);
            if (result == null) {
                return BadRequest("Unable to delete, this pet doesn't exist");
            }
            
            return Ok("The pet was deleted successfully");
        }
    }
}