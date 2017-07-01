using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    abstract class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public String Cpf { get; set; }

        [Required]
        public String Rg { get; set; }

        [Required]
        public String TelefoneContato { get; set; }

    }
}
