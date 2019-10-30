using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TW.Models
{
    [Table("INTERESSE")]
    public partial class Interesse
    {
        [Key]
        [Column("id_interesse")]
        public int IdInteresse { get; set; }
        [Column("id_usuario")]
        public int? IdUsuario { get; set; }
        [Column("id_status_interesse")]
        public int? IdStatusInteresse { get; set; }
        [Column("id_classificado")]
        public int? IdClassificado { get; set; }

        [ForeignKey(nameof(IdClassificado))]
        [InverseProperty(nameof(Classificado.Interesse))]
        public virtual Classificado IdClassificadoNavigation { get; set; }
        [ForeignKey(nameof(IdStatusInteresse))]
        [InverseProperty(nameof(StatusInteresse.Interesse))]
        public virtual StatusInteresse IdStatusInteresseNavigation { get; set; }
        [ForeignKey(nameof(IdUsuario))]
        [InverseProperty(nameof(Usuario.Interesse))]
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
