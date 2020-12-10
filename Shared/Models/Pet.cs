using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleDB.Shared.Models {
    [Table("Pet")]
    public class Pet {
        
        [Key]
        public uint Id { get; set; }
        [Required(ErrorMessage = "Mandatory Field"),
         MaxLength(100)]
        public string PetSpecies { get; set; }
        [Required(ErrorMessage = "Mandatory Field"), 
         MaxLength(50)]
        public string PetName { get; set; }
        [Required(ErrorMessage = "Mandatory Field"), 
         MaxLength(8, ErrorMessage = "Pet Reg Number must be 8 digits exactly"), 
         MinLength(8, ErrorMessage = "Pet Reg Number must be 8 digits exactly"),
         RegularExpression(@"^\d{8}$", ErrorMessage = "Pet Reg Number must be 8 digits exactly")]
        public string PetRegistrationNumber { get; set; }
        
        public uint PersonId { get; set; }
        public Person Person { get; set; }
    }
}