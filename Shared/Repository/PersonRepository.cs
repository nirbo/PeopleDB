using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeopleDB.Shared.Context;
using PeopleDB.Shared.Models;

namespace PeopleDB.Shared.Repository {
    
    public class PersonRepository : IPersonRepository {

        private readonly AppDbContext _dbContext;

        public PersonRepository(AppDbContext dbContext) {
            _dbContext = dbContext;
        }
        
        public List<Person> GetAllPersons() {
            return _dbContext.Persons
                .Include(p => p.Addresses)
                .Include(p => p.Pets)
                .Include(p => p.Vehicles)
                .ToList();
        }

        public async Task<Person> GetPersonById(uint? id) {
            Person person = await _dbContext.Persons
                .Include(p => p.Addresses)
                .Include(p => p.Pets)
                .Include(p => p.Vehicles)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (person == null) {
                return null;
            }
            
            return person;
        }

        public async Task<Person> CreatePerson(Person person) {
            await _dbContext.Persons.AddAsync(person);
            _dbContext.SaveChanges();
            return person;
        }

        public async Task UpdatePerson(Person person) {
            var local = await _dbContext.Set<Person>()
                .Include(p => p.Addresses)
                .Include(p => p.Pets)
                .Include(p => p.Vehicles)
                .FirstAsync(entry => entry.Id.Equals(person.Id));

            if (local != null) {
                _dbContext.Entry(local).State = EntityState.Detached;
            }

            _dbContext.Entry(person).State = EntityState.Modified;
            _dbContext.Persons.Update(person);
            _dbContext.SaveChanges();
        }

        public async Task<string> DeletePerson(uint? id) {
            Person person = await GetPersonById(id);
            if (person == null) {
                return null;
            }

            _dbContext.Persons.Remove(person);
            await _dbContext.SaveChangesAsync();
            return "Person deleted successfully";
        }
    }
}