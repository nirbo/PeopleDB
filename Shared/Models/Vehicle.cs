using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleDB.Shared.Models {
    [Table("Vehicle")]
    public class Vehicle {
        
        [Key]
        public uint Id { get; set; }
        public string VehicleIdNumber { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public short VehicleYear { get; set; }
        public string VehicleColor { get; set; }
        
        public uint PersonId { get; set; }
        public Person Person { get; set; }
    }
}