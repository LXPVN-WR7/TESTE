using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TW.Models
{
    [Table("CLASSIFICADO")]
    public partial class Classificado
    {
        public Classificado()
        {
            Interesse = new HashSet<Interesse>();
        }

        [Key]
        [Column("id_classificado")]
        public int IdClassificado { get; set; }
        [Column("preco", TypeName = "money")]
        public decimal Preco { get; set; }
        [Required]
        [Column("numero_de_serie")]
        [StringLength(60)]
        public string NumeroDeSerie { get; set; }
        [Required]
        [Column("observacao")]
        [StringLength(255)]
        public string Observacao { get; set; }
        [Column("fim_de_vida_util", TypeName = "date")]
        public DateTime FimDeVidaUtil { get; set; }
        [Column("data_fabricacao", TypeName = "date")]
        public DateTime DataFabricacao { get; set; }
        [Column("id_equipamento")]
        public int? IdEquipamento { get; set; }
        [Column("id_status_classificado")]
        public int? IdStatusClassificado { get; set; }

        [ForeignKey(nameof(IdEquipamento))]
        [InverseProperty(nameof(Equipamento.Classificado))]
        public virtual Equipamento IdEquipamentoNavigation { get; set; }
        [ForeignKey(nameof(IdStatusClassificado))]
        [InverseProperty(nameof(StatusClassificado.Classificado))]
        public virtual StatusClassificado IdStatusClassificadoNavigation { get; set; }
        [InverseProperty("IdClassificadoNavigation")]
        public virtual ICollection<Interesse> Interesse { get; set; }
    }
}
