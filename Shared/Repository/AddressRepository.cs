using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeopleDB.Shared.Context;
using PeopleDB.Shared.Models;

namespace PeopleDB.Shared.Repository {
    
    public class AddressRepository : IAddressRepository {

        private readonly AppDbContext _dbContext;

        public AddressRepository(AppDbContext dbContext) {
            _dbContext = dbContext;
        }
        
        public List<Address> GetAllAddresses() {
            return _dbContext.Addresses.ToList();
        }

        public async Task<Address> GetAddressById(uint? id) {
            Address address = await _dbContext.Addresses.FindAsync(id);
            if (address == null) {
                return null;
            }

            return address;
        }

        public async Task<Address> CreateAddress(Address address) {
            await _dbContext.Addresses.AddAsync(address);
            _dbContext.SaveChanges();
            return address;
        }

        public void UpdateAddress(Address address) {
            var local = _dbContext.Set<Address>()
                .Local
                .FirstOrDefault(entry => entry.Id.Equals(address.Id));

            if (local != null) {
                _dbContext.Entry(local).State = EntityState.Detached;
            }

            _dbContext.Entry(address).State = EntityState.Modified;
            _dbContext.Addresses.Update(address);
            _dbContext.SaveChanges();

        }

        public async Task<string> DeleteAddress(uint? id) {
            Address address = await GetAddressById(id);
            if (address == null) {
                return null;
            }

            _dbContext.Addresses.Remove(address);
            await _dbContext.SaveChangesAsync();
            return "Address deleted successfully";
        }
    }
}