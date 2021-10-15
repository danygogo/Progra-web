using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DesingYourParadise.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "La cédula es requerida")]
        public int Cedula { get; set; }


        [Required(ErrorMessage = "El nombre es requerido")]
        public String Nombre { get; set; }


        [Required(ErrorMessage = "El telefono es requerido")]
        public int Telefono { get; set; }

        public List<Models.Proyecto> Projects { get; set; }

        public Cliente()
        {
            Projects = new List<Proyecto>();
        }
    }
}
