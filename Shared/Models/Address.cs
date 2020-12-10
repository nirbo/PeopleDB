using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleDB.Shared.Models {
    [Table("Address")]
    public class Address {
        
        [Key]
        public uint Id { get; set; }
        [Required, MaxLength(100)]
        public string Address1 { get; set; }
        [MaxLength(50)]
        public string Address2 { get; set; }
        [Required, MaxLength(100)]
        public string City { get; set; }
        [Required, MaxLength(6)]
        public string PostalCode { get; set; }
        [Required]
        public string Province { get; set; }
        [Required, MaxLength(100)]
        public string Country { get; set; }
        
        public uint PersonId { get; set; }
        public Person Person { get; set; }
    }
}