using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(5, ErrorMessage = "No mínimo 5 caracteres")]
        [MaxLength(50, ErrorMessage = "No máximo 50 caracteres")]
        [Display(Name = "* Nome do usuário")]
        public string UsuarioNome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(5, ErrorMessage = "No mínimo 5 caracteres")]
        [MaxLength(50, ErrorMessage = "No máximo 50 caracteres")]
        [Display(Name = "* Email do usuário")]
        [EmailAddress]
        public string UsuarioEmail { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(5, ErrorMessage = "No mínimo 5 caracteres")]
        [MaxLength(50, ErrorMessage = "No máximo 50 caracteres")]
        [Display(Name = "* Login do usuário")]
        public string UsuarioLogin { get; set; }

        [Display(Name = "* Senha do usuário")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string UsuarioSenha { get; set; }

        [Display(Name = "* Confirmação de senha")]
        [Compare("UsuarioSenha", ErrorMessage="Os campos não coincidem")]
        [NotMapped]
        public string UsuarioConfirmacaoSenha { get; set; }
    }
}