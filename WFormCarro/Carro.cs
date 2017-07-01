using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFormCarro
{
    [Table("Carro")]
    class Carro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public String Placa { get; set; }
        public int Portas { get; set; }

        override public string ToString()
        {
            return this.Placa + ", Portas: " + this.Portas;
        }
    }
}
