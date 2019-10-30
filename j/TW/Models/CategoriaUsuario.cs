using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TW.Models
{
    [Table("CATEGORIA_USUARIO")]
    public partial class CategoriaUsuario
    {
        public CategoriaUsuario()
        {
            Usuario = new HashSet<Usuario>();
        }

        [Key]
        [Column("id_categoria_usuario")]
        public int IdCategoriaUsuario { get; set; }
        [Required]
        [Column("nome_categoria_usuario")]
        [StringLength(50)]
        public string NomeCategoriaUsuario { get; set; }

        [InverseProperty("IdCategoriaUsuarioNavigation")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
