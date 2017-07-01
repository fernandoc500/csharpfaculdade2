using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    [Table("Comentarios")]
    public class Comentario
    {
        [Key]
        public int ComentarioId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(5, ErrorMessage = "No mínimo 5 caracteres")]
        [MaxLength(50, ErrorMessage = "No máximo 50 caracteres")]
        [Display(Name = "* Autor do comentário")]
        public string ComentarioAutor { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public DateTime ComentarioDataDeCriacao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(5, ErrorMessage = "No mínimo 5 caracteres")]
        [MaxLength(250, ErrorMessage = "No máximo 250 caracteres")]
        [Display(Name = "* Corpo do comentário")]
        [DataType(DataType.MultilineText)]
        public string ComentarioCorpo { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public Post ComentarioPost { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public string ComentarioPostId { get; set; }
    }
}