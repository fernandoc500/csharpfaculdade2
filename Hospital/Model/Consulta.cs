using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    [Table("consulta")]
    public class Consulta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [InverseProperty("Consultas")]
        private Medico MedicoResponsavel { get; set; }

        [Required]
        [InverseProperty("Consultas")]
        private Paciente PacienteAtendido { get; set; }

        [Required]
        public DateTime HorarioAgendado { get; set; }

        public Boolean Realizada { get; set; }

    }
}
