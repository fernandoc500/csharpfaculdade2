using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    [Table("banco")]
    class Banco
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}
