using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace property.Models
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ClientId { get; set; }

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

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string PassportDetails { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
