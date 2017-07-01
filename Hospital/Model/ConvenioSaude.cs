using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    [Table("convenio_saude")]
    class ConvenioSaude
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public String Telefone { get; set; }

        public ICollection<PlanoSaude> PlanosDeSaude { get; set; }
    }
}
