using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    [Table("turno")]
    class Turno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public DateTime HorarioInicio { get; set; }

        [Required]
        public DateTime HorarioFim { get; set; }

        public ICollection<Medico> Medicos { get; set; }
    }
}
