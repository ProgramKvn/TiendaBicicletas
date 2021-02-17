using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TiendaBicicleta.Models
{
    public class RegistroVenta : EntityBase
    {
        [Required(ErrorMessage = "Necesita llenar este campo")]
        [Display(Name = "Id del cliente")]
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        [Required(ErrorMessage = "Necesita llenar este campo")]
        [Display(Name = "Id de la bicicleta")]
        public int InventarioBicicletaId { get; set; }
        [ForeignKey("InventarioBicicletaId")]
        public InventarioBicicleta InventarioBicicleta { get; set; }
    }
}
