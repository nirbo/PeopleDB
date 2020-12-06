using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PeopleDB.Shared.Models {
    [Table("Person")]
    public class Person {
        
        [Key]
        public uint Id { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public string lastName { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public uint sin { get; set; }
        
        [AllowNull]
        public Address address { get; set; }
        [AllowNull]
        public ICollection<Vehicle> vehicles { get; set; }
        [AllowNull]
        public ICollection<Pet> pets { get; set; }
    }
}