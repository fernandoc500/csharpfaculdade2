using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    [Table("plano_saude")]
    class PlanoSaude
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        [InverseProperty("PlanosDeSaude")]
        public ConvenioSaude EmpresaConvenio { get; set; }

        public ICollection<Paciente> Pacientes { get; set; }
    }
}
