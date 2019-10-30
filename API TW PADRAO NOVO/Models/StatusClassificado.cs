using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TW.Models
{
    [Table("STATUS_CLASSIFICADO")]
    public partial class StatusClassificado
    {
        public StatusClassificado()
        {
            Classificado = new HashSet<Classificado>();
        }

        [Key]
        [Column("id_status_classificado")]
        public int IdStatusClassificado { get; set; }
        [Required]
        [Column("nome_status_classificado")]
        [StringLength(50)]
        public string NomeStatusClassificado { get; set; }

        [InverseProperty("IdStatusClassificadoNavigation")]
        public virtual ICollection<Classificado> Classificado { get; set; }
    }
}
