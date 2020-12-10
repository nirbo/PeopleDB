using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeopleDB.Shared.Context;
using PeopleDB.Shared.Models;

namespace PeopleDB.Shared.Repository {
    
    public class PetRepository : IPetRepository {
        
        private readonly AppDbContext _dbContext;

        public PetRepository(AppDbContext dbContext) {
            _dbContext = dbContext;
        }
        
        public List<Pet> GetAllPets() {
            return _dbContext.Pets.ToList();
        }

        public async Task<Pet> GetPetById(uint? id) {
            Pet pet = await _dbContext.Pets.FirstAsync(p => p.Id == id);
            if (pet == null) {
                return null;
            }
            
            return pet;
        }

        public async Task<Pet> CreatePet(Pet pet) {
            await _dbContext.Pets.AddAsync(pet);
            _dbContext.SaveChanges();
            return pet;
        }

        public void UpdatePet(Pet pet) {
            var local = _dbContext.Set<Pet>()
                .Local
                .FirstOrDefault(entry => entry.Id.Equals(pet.Id));

            if (local != null) {
                _dbContext.Entry(local).State = EntityState.Detached;
            }

            _dbContext.Entry(pet).State = EntityState.Modified;
            _dbContext.Pets.Update(pet);
            _dbContext.SaveChanges();
        }

        public async Task<string> DeletePet(uint? id) {
            Pet pet = await GetPetById(id);
            if (pet == null) {
                return null;
            }

            _dbContext.Pets.Remove(pet);
            await _dbContext.SaveChangesAsync();
            return "Pet deleted successfully";
        }
    }
}