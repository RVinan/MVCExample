using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjrv.Models
{
    public class tipoAnimal
    {
        public int tipoAnimalId { get; set; }
        public string tipo { get; set; }
        public virtual animal Animal { get; set; }
        
    }
}