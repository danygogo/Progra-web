
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesingYourParadise.Models
{
    public class Proyecto
    {
        public int IdProyecto { get; set; }
        public int IdCliente { get; set; }
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




/*
 * 
 * En el controlador del padre al agregar el padre (post)
 persona.Hijos.Add(new Models.Hijo() { Id = 1, IdPadre = persona.Id, Nombre = "Hijo 1", Apellidos = "Apellidos Hijo 1" });
persona.Hijos.Add(new Models.Hijo() { Id = 1, IdPadre = persona.Id, Nombre = "Hijo 2", Apellidos = "Apellidos Hijo 2" });

listaDePersonas.Add(persona);
return RedirectToAction(nameof(Index));
 
 
 */


/* En el padre
 {
    public class Persona
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public List<Models.Hijo> Hijos { get; set; }

        public Persona()
        {
            Hijos = new List<Hijo>();
        }
    }
}
 
 */