using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace property.Models
{
    [Table("Agent")]
    public class Agent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AgentId { get; set; }

        [Required]
        [MaxLength(150)]
        [Column(TypeName = "varchar(150)")]
        public string FirstName { get; set; }

        [MaxLength(150)]
        [Column(TypeName = "varchar(150)")]
        public string LastName { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string PhoneNumber { get; set; }

        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string AgencyName { get; set; }

        [Column(TypeName = "numeric(5,2)")]
        public decimal CommissionRate { get; set; }

        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Property> Properties { get; set; }
    }
}
