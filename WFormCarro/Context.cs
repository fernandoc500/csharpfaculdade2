using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFormCarro
{
    class Context : DbContext
    {
        public DbSet<Carro> Carros { get; set; }
    }
}