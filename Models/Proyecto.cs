
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesingYourParadise.Models
{
    public class Proyecto
    {
        [Range(1, 10000, ErrorMessage = "La capacidad máxima de proyectos es de 10.000, contacte a su proveedor de software")]
        public int IdProyecto { get; set; }

        
        public String IdCliente { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [MinLength(10, ErrorMessage = "Escriba al menos 10 caracteres")]
        [MaxLength(60, ErrorMessage = "Longitud Máxima 60 caracteres")]
        public String NombreProyecto { get; set; }
        public CantidadDormitorios Dormitorios { get; set; }
        public Bathrooms Bathrooms { get; set; }
        public HalfBathrooms HalfBathrooms{ get; set; }
        public Boolean SalaMasCocina { get; set; }
        public Boolean PilasAbierta { get; set; }
        public TerrazaSize Terraza{ get; set; }
        public TipoPiso Piso { get; set; }
        public MuebleCocina Mueble{ get; set; }
        public Metros Metros { get; set; }
        public double Costo { get; set; }
        public double Costo_Dolar { get; set; }
        public byte[] Foto { get; set; }
    }
}

