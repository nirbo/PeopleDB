using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeopleDB.Shared.Models;
using PeopleDB.Shared.Repository;

namespace PeopleDB.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase {

        private readonly IPersonRepository personRepository;

        public PersonController(IPersonRepository _personRepository) {
            personRepository = _personRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllPersons() {
            List<Person> allPersons = personRepository.GetAllPersons();
            if (allPersons.Count == 0) {
                return BadRequest("The DB is empty, please create a new person entry");
            }

            return Ok(allPersons);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetPersonById(uint? id) {
            Person person = await personRepository.GetPersonById(id);
            if (person == null) {
                return NotFound($"Person entry with the Id {id} does not exist");
            }

            return Ok(person);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreatePerson([FromBody] Person person) {
            Person createdPerson = await personRepository.CreatePerson(person);
            if (createdPerson != null) {
                return new CreatedAtActionResult("GetPerson", "Person", new { createdPerson.Id }, createdPerson);
            } else {
                return BadRequest("An error has occurred, please try again");
            }
        }
        
        [HttpPut("Update")]
        public IActionResult UpdatePerson([FromBody] Person person) {
            if (person == null) throw new ArgumentNullException(nameof(person));
            personRepository.UpdatePerson(person);
            return Ok("The person was updated successfully");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeletePerson(uint? id) {
            string result = await personRepository.DeletePerson(id);
            if (result == null) {
                return BadRequest("Unable to delete, this person doesn't exist");
            }
            
            return Ok("The person was deleted successfully");
        }
    }
}