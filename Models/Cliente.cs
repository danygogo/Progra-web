using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesingYourParadise.Models
{
    public class Cliente
    {

        [Required(ErrorMessage = "La cédula es requerida")]
        [RegularExpression("^0[0-9]{1}-[0-9]{4}-[0-9]{4}$|^[0-9]{1}-[0-9]{3}-[0-9]{6}$", ErrorMessage = "Formato cédula física 0#-####-####, cédula jurídica #-###-######")]
        public String Cedula { get; set; }


        [Required(ErrorMessage = "El nombre es requerido")]
        [MinLength(10, ErrorMessage = "Escriba al menos 10 caracteres")]
        [MaxLength(60, ErrorMessage = "Longitud Máxima 60 caracteres")]
        public String Nombre { get; set; }


        [Required(ErrorMessage = "El telefono es requerido")]
        [RegularExpression("^[0-9]{4}-[0-9]{4}$", ErrorMessage = "El formato de número de teléfono es 1234-5678")]
        public String Telefono { get; set; }
    }
}
