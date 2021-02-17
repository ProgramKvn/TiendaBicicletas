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
    public class EditarRegistroModel : PageModel
    {
        private readonly IRegistroVentaRepository _registroVentaRepository;

        public EditarRegistroModel(IRegistroVentaRepository registroVentaRepository)
        {
            _registroVentaRepository = registroVentaRepository;
        }
        [BindProperty]
        public RegistroVenta RegistroVenta { get; set; }
        public IActionResult OnGet(int Id)
        {
            RegistroVenta = _registroVentaRepository.GetById(Id);
            if (RegistroVenta == null)
            {
                return NotFound();
            }

            return Page();
        }
        public IActionResult OnPost(int Id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var ActualizarRegistro = _registroVentaRepository.GetById(Id);
            if (ActualizarRegistro == null)
            {
                return NotFound();
            }
            ActualizarRegistro.ClienteId = RegistroVenta.ClienteId;
            ActualizarRegistro.InventarioBicicletaId = RegistroVenta.InventarioBicicletaId;

            _registroVentaRepository.Actualizar(ActualizarRegistro);

            return RedirectToPage("/RegistroVentas/MostrarVentas");
        }

    }
}
