using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required(ErrorMessage="Campo obrigatório")]
        [MinLength(5, ErrorMessage="No mínimo 5 caracteres")]
        [MaxLength(50, ErrorMessage = "No máximo 50 caracteres")]
        [Display(Name = "* Título do post")]
        public string PostTitulo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(5, ErrorMessage = "No mínimo 5 caracteres")]
        [MaxLength(2000, ErrorMessage = "No máximo 2000 caracteres")]
        [Display(Name = "* Corpo do post")]
        [DataType(DataType.MultilineText)]
        public string PostCorpo { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public DateTime PostDataDeCriacao { get; set; }

        
        public virtual Usuario PostAutor { get; set; }
    }
}