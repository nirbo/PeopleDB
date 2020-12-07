using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

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
        
        [AllowNull]
        public Address address { get; set; }
        [AllowNull]
        public ICollection<Vehicle> vehicles { get; set; }
        [AllowNull]
        public ICollection<Pet> pets { get; set; }
    }
}