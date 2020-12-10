using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleDB.Shared.Models {
    [Table("Person")]
    public class Person {
        
        [Key]
        public uint Id { get; set; }
        [Required(ErrorMessage = "Mandatory Field"), MaxLength(70, ErrorMessage = "This field can contain up to 70 characters")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Mandatory Field"), MaxLength(70, ErrorMessage = "This field can contain up to 70 characters")]
        public string lastName { get; set; }
        [Required(ErrorMessage = "Mandatory Field"), 
         MaxLength(9, ErrorMessage = "SIN must be 9 digits exactly"),
         RegularExpression(@"^\d{9}$", ErrorMessage = "SIN must be 9 digits exactly"), 
         MinLength(9, ErrorMessage = "SIN must be 9 digits exactly")]
        public string sin { get; set; }
        
        public List<Address> Addresses { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Pet> Pets { get; set; }
    }
}