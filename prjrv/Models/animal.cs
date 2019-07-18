using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjrv.Models
{
    public class animal
    {
        public int animalId { get; set; }
        public string especie { get; set; }
        public int tipoAnimalId { get; set; }
        public virtual ICollection<tipoAnimal> TipoAnimals { get; set; }
    }
}