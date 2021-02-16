using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TiendaBicicleta.Data.Interfaz;
using TiendaBicicleta.Models;

namespace TiendaBicicleta.Web.Pages
{
    public class EliminarRegistroModel : PageModel
    {
        private readonly IInventarioBicicletaRepository _inventarioRepository;

        public EliminarRegistroModel(IInventarioBicicletaRepository inventarioRepository)
        {
            _inventarioRepository = inventarioRepository;
        }
        [BindProperty]
        public InventarioBicicleta InventarioBicicleta { get; set; }
        public IActionResult OnPost(int Id)
        {
            var RegistroSeleccionado = _inventarioRepository.GetById(Id);
            if (RegistroSeleccionado == null)
                return NotFound();

            _inventarioRepository.Borrar(RegistroSeleccionado);
            return RedirectToPage("./InventarioBicicletas");
        }
    }
}
