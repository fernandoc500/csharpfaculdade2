using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    [Table("medico")]
    class Medico : Pessoa
    {
        [Required]
        public String Crm { get; set; }

        [Required]
        [InverseProperty("Medicos")]
        public AreaAtuacao AreaDeAtuacao { get; set; }

        [Required]
        [InverseProperty("Medicos")]
        public Turno TurnoTrabalho { get; set; }

        public ICollection<Consulta> Consultas { get; set; }
    }
}
