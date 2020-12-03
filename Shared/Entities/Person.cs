using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleDB.Shared.Entities {
    [Table("Person")]
    public class Person {
        
        [Key]
        public uint Id { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public uint sin { get; set; }
        
        public Address address { get; set; }
        public ICollection<Vehicle> vehicles { get; set; }
        public ICollection<Pet> pets { get; set; }
    }
}