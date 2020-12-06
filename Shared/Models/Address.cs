using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleDB.Shared.Models {
    [Table("Address")]
    public class Address {
        
        [Key, ForeignKey("Person")]
        public uint Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        [MaxLength(6)]
        public string PostalCode { get; set; }
        [MaxLength(2)]
        public string Province { get; set; }
        public string Country { get; set; }
        
        public Person Person { get; set; }
    }
}