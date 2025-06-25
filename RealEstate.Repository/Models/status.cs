using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace property.Models
{
    public class Status
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long StatusId { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }
    }
}
