using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ModificarPersonas_Entities
{

    public class clsPersona
    {
        [HiddenInput(DisplayValue = false) ]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Nombre obligatorio")]
        [StringLength(30, MinimumLength = 3)]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Campo Apellidos Obligatorio")]
        [StringLength(40, MinimumLength = 3)]
        public string apellidos { get; set; }

        [DataType(DataType.Date, ErrorMessage = "La fecha debe introducirse")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",ApplyFormatInEditMode = true)]
        public DateTime fechaNac { get; set; }

        [RegularExpression("[0-9]{3}[0-9]{3}[0-9]{3}", ErrorMessage = "El número de telefono tiene que ser de tipo XXXXXXXXX")]
        
        public string telefono { get; set; }


        //Constructores

        public clsPersona(int id, string nombre, string apellidos, DateTime fechaNac, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.fechaNac = fechaNac;
        }

        public clsPersona(string _nombre, string _apellidos)
        {
            this.nombre = _nombre;
            this.apellidos = _apellidos;
        }

        public clsPersona()
        {

        }



        public int GetEdad()
        {
            var hoy = DateTime.Now;
            var edad = hoy.Year - fechaNac.Year;
            if (fechaNac.AddYears(edad) > hoy)
            {
                edad--;
            }
            return edad;
        }

    }
}
