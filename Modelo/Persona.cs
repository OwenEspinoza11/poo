using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        [Required]
        [Display(Name = "Código", Description ="Introduzca un entero entre 0 y 99999.")]
        [Range(0, 99999)]
        public int Id {
            get { return id; }
            set {
                Validator.ValidateProperty(value, 
                    new ValidationContext(this, null, null) { MemberName = "Id" });
                id = value; 
            } 
        }
    }
}
