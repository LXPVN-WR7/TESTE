using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TW.Models
{
    [Table("EQUIPAMENTO")]
    public partial class Equipamento
    {
        public Equipamento()
        {
            Classificado = new HashSet<Classificado>();
        }

        [Key]
        [Column("id_equipamento")]
        public int IdEquipamento { get; set; }
        [Required]
        [Column("nome_equipamento")]
        [StringLength(50)]
        public string NomeEquipamento { get; set; }
        [Required]
        [Column("fabricante")]
        [StringLength(50)]
        public string Fabricante { get; set; }
        [Required]
        [Column("descricao")]
        [StringLength(255)]
        public string Descricao { get; set; }
        [Required]
        [Column("modelo")]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Column("id_categoria")]
        public int? IdCategoria { get; set; }

        [ForeignKey(nameof(IdCategoria))]
        [InverseProperty(nameof(Categoria.Equipamento))]
        public virtual Categoria IdCategoriaNavigation { get; set; }
        [InverseProperty("IdEquipamentoNavigation")]
        public virtual ICollection<Classificado> Classificado { get; set; }
    }
}
