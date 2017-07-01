using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    class HospitalContext : DbContext
    {
        public DbSet<AreaAtuacao> AreasAtuacao { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<ConvenioSaude> ConveniosSaude { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PlanoSaude> PlanosSaude { get; set; }
        public DbSet<Turno> Turnos { get; set; }
    }
}
