using System.Collections.Generic;
using System.Threading.Tasks;
using PeopleDB.Shared.Models;

namespace PeopleDB.Shared.Repository {
    
    public interface IPersonRepository {
        
        List<Person> GetAllPersons();

        Task<Person> GetPersonById(uint? id);

        Task<Person> CreatePerson(Person person);

        void UpdatePerson(Person person);

        Task<string> DeletePerson(uint? id);
    }
}