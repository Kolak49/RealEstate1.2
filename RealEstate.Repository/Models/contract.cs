using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace property.Models
{
    public class Contract
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ContractId { get; set; }

        public long AgentId { get; set; }
        public Agent Agent { get; set; }

        public long ClientId { get; set; }
        public Client Client { get; set; }

        public long PropertyId { get; set; }
        public Property Property { get; set; }

        public DateTime StartDate { get; set; }

        [Column(TypeName = "numeric(18,2)")]
        public decimal Price { get; set; }

        public long StatusId { get; set; }
        public Status Status { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string ContractType { get; set; }
    }
}
