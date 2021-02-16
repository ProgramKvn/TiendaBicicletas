using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TiendaBicicleta.Models
{
    public class Cliente : EntityBase
    {
        [Required(ErrorMessage = "Necesita llenar este campo")]
        [MinLength(5, ErrorMessage = "El mínimo de carácteres para este campo es de 2")]
        [MaxLength(15, ErrorMessage = "El máximo de carácteres para este campo es de 70")]
        [Display(Name = "Nombres del cliente")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Necesita llenar este campo")]
        [MinLength(5, ErrorMessage = "El mínimo de carácteres para este campo es de 3")]
        [MaxLength(15, ErrorMessage = "El máximo de carácteres para este campo es de 255")]
        [Display(Name = "Apellidos del cliente")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Necesita llenar este campo")]
        [Display(Name = "Número telefónico del cliente")]
        public int Telefono { get; set; }
    }
}
