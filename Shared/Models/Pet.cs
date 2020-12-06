using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleDB.Shared.Models {
    [Table("Pet")]
    public class Pet {
        
        [Key, ForeignKey("Person")]
        public uint Id { get; set; }
        public string PetSpecies { get; set; }
        public string PetName { get; set; }
        public uint PetRegistrationNumber { get; set; }
        
        public Person Person { get; set; }
    }
}