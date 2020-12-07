using System.Collections.Generic;
using System.Threading.Tasks;
using PeopleDB.Shared.Models;

namespace PeopleDB.Shared.Repository {
    
    public interface IAddressRepository {
        
        List<Address> GetAllAddresses();

        Task<Address> GetAddressById(uint? id);

        Task<Address> CreateAddress(Address address);

        void UpdateAddress(Address address);

        Task<string> DeleteAddress(uint? id);
    }
}