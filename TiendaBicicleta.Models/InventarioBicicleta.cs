using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TiendaBicicleta.Models
{
    public class InventarioBicicleta : EntityBase
    {
        [Required(ErrorMessage = "Necesita llenar este campo")]
        [MinLength(5, ErrorMessage = "El mínimo de carácteres para este campo es de 5")]
        [MaxLength(15, ErrorMessage = "El máximo de carácteres para este campo es de 15")]
        [Display(Name = "Modelo de Bicicleta")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Necesita llenar este campo")]
        [Display(Name = "Precio de la Bicicleta")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "Necesita llenar este campo")]
        [MinLength(2, ErrorMessage = "El mínimo de carácteres para este campo es de 5")]
        [MaxLength(15, ErrorMessage = "El máximo de carácteres para este campo es de 15")]
        [Display(Name = "Color de Bicicleta")]
        public string Color { get; set; }
    }
}
