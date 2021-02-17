using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TiendaBicicleta.Data.Interfaz;
using TiendaBicicleta.Models;

namespace TiendaBicicleta.Web.Pages.RegistroVentas
{
    public class MostrarVentasModel : PageModel
    {
        private readonly IRegistroVentaRepository _registroVentasRepository;

        public MostrarVentasModel(IRegistroVentaRepository registroVentasRepository)
        {
            _registroVentasRepository = registroVentasRepository;
        }
        [BindProperty]
        public IEnumerable<RegistroVenta> RegistroVentas { get; set; }
        public IActionResult OnGet()
        {
            RegistroVentas = _registroVentasRepository.List();
            return Page();
        }
    }
}
