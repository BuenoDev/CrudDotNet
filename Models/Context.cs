using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace crudNetWeb.Models
{
    public class Context : DbContext
    {
        public DbSet<PacienteModel> Pacientes { get; set; }
    }
}