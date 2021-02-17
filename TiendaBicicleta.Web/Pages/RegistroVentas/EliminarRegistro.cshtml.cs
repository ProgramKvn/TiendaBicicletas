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
    public class EliminarRegistroModel : PageModel
    {
        private readonly IRegistroVentaRepository _registroVentaRepository;

        public EliminarRegistroModel(IRegistroVentaRepository registroVentaRepository)
        {
            _registroVentaRepository = registroVentaRepository;
        }
        [BindProperty]
        public RegistroVenta RegistroVenta { get; set; }
        public IActionResult OnPost(int Id)
        {
            var RegistroSeleccionado = _registroVentaRepository.GetById(Id);
            if(RegistroSeleccionado == null)
            {
                return NotFound();
            }
            _registroVentaRepository.Borrar(RegistroSeleccionado);
            return RedirectToPage("/RegistroVentas/MostrarVentas");
        }
    }
}
