using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace property.Models
{
    public class Property
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PropertyId { get; set; }

        public long OwnerId { get; set; }
        public Owner Owner { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string PropertyType { get; set; }

        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string Address { get; set; }

        [Column(TypeName = "numeric(18,2)")]
        public decimal Price { get; set; }

        public double Area { get; set; }
        public int Rooms { get; set; }
        public int Floor { get; set; }

        public long AgentId { get; set; }
        public Agent Agent { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
