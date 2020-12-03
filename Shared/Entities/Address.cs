using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleDB.Shared.Entities {
    [Table("Address")]
    public class Address {
        
        [Key, ForeignKey("Person")]
        public uint Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }
        
        public Person Person { get; set; }
    }
}