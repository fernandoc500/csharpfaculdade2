using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2905
{
    class CarroContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }
    }
}
