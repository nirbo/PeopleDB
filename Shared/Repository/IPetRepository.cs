using System.Collections.Generic;
using System.Threading.Tasks;
using PeopleDB.Shared.Models;

namespace PeopleDB.Shared.Repository {
    
    public interface IPetRepository {
        
        List<Pet> GetAllPets();

        Task<Pet> GetPetById(uint? id);

        Task<Pet> CreatePet(Pet pet);

        void UpdatePet(Pet pet);

        Task<string> DeletePet(uint? id);
    }
}