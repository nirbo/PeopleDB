using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeopleDB.Shared.Models;

namespace PeopleDB.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase {
        private readonly AppDbContext _context;

        public PersonController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetAllPersons() {
            List<Person> allPersons = await _context.Persons.ToListAsync();
            return Ok(allPersons);
        }

        [HttpGet("{id}", Name = "GetPersonById")]
        public async Task<ActionResult<Person>> GetPersonById(uint id) {
            Person person = await _context.Persons.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(person);
        }

        [HttpPost]
        public async Task<ActionResult> CreatePerson(Person person) {
            _context.Add(person);
            await _context.SaveChangesAsync();
            return Ok(person.Id);
        }
        
        [HttpPut]
        public async Task<ActionResult> UpdatePerson(Person person) {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePersonById(uint id)
        {
            var person = new Person { Id = id };
            _context.Remove(person);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}