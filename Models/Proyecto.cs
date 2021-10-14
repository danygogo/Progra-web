
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesingYourParadise.Models
{
    public class Proyecto
    {
        public int IdProyecto { get; set; }
        public String NombreProyecto { get; set; }
        public CantidadDormitorios dormitorios { get; set; }
        public Bathrooms bathrooms { get; set; }
        public HalfBathrooms halfBathrooms{ get; set; }
        public Boolean SalaMasCocina { get; set; }
        public Boolean PilasAbierta { get; set; }
        public TerrazaSize terraza{ get; set; }
        public TipoPiso piso { get; set; }
        public MuebleCocina mueble{ get; set; }
        public Metros metros { get; set; }
        public double costo { get; set; }
    }
}
