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
    public class CrearRegistroModel : PageModel
    {
        private readonly IRegistroVentaRepository _registroVentaRepository;

        public CrearRegistroModel(IRegistroVentaRepository registroVentaRepository)
        {
            _registroVentaRepository = registroVentaRepository;
        }
        [BindProperty]
        public RegistroVenta RegistroVenta { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return NotFound();

            _registroVentaRepository.Insertar(RegistroVenta);
            return RedirectToPage("/RegistroVentas/MostrarVentas");
        }
    }
}
