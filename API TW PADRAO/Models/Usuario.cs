﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TW.Models
{
    [Table("USUARIO")]
    public partial class Usuario
    {
        public Usuario()
        {
            Interesse = new HashSet<Interesse>();
        }

        [Key]
        [Column("id_usuario")]
        public int IdUsuario { get; set; }
        [Required]
        [Column("nome_completo")]
        [StringLength(100)]
        public string NomeCompleto { get; set; }
        [Required]
        [Column("nome_usuario")]
        [StringLength(50)]
        public string NomeUsuario { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [Column("senha")]
        [StringLength(255)]
        public string Senha { get; set; }
        [Column("id_categoria_usuario")]
        public int? IdCategoriaUsuario { get; set; }

        [ForeignKey(nameof(IdCategoriaUsuario))]
        [InverseProperty(nameof(CategoriaUsuario.Usuario))]
        public virtual CategoriaUsuario IdCategoriaUsuarioNavigation { get; set; }
        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Interesse> Interesse { get; set; }
    }
}
