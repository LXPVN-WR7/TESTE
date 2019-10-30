using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TW.Models
{
    [Table("STATUS_INTERESSE")]
    public partial class StatusInteresse
    {
        public StatusInteresse()
        {
            Interesse = new HashSet<Interesse>();
        }

        [Key]
        [Column("id_status_interesse")]
        public int IdStatusInteresse { get; set; }
        [Required]
        [Column("nome_status_interesse")]
        [StringLength(50)]
        public string NomeStatusInteresse { get; set; }

        [InverseProperty("IdStatusInteresseNavigation")]
        public virtual ICollection<Interesse> Interesse { get; set; }
    }
}
