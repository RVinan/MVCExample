using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace prjrv.Models
{
    public class EjemploDB : DbContext
    {
        public DbSet<tipoAnimal> tipoAnimals { get; set; }
        public DbSet<animal> animals { get; set; }


    }
}