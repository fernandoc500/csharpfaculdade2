using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    [Table("funcionario")]
    class Funcionario : Pessoa
    {
        [Required]
        public decimal Salario { get; set; }

        [Required]
        [InverseProperty("Funcionarios")]
        public Banco BancoConta { get; set; }

        [Required]
        public String AgenciaBancaria { get; set; }

        [Required]
        public String ContaCorrente { get; set; }
    }
}
