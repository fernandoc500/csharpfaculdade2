using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    [Table("paciente")]
    class Paciente : Pessoa
    {
        [Required]
        [InverseProperty("Pacientes")]
        public PlanoSaude PlanoDeSaude { get; set; }

        public ICollection<Consulta> Consultas { get; set; }
    }
}
