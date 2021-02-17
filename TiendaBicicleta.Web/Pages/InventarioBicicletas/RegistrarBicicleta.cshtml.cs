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
    public class RegistrarBicicletaModel : PageModel
    {
        private readonly IInventarioBicicletaRepository _inventarioRepository;

        public RegistrarBicicletaModel(IInventarioBicicletaRepository inventarioRepository)
        {
            _inventarioRepository = inventarioRepository;
        }
        [BindProperty]
        public InventarioBicicleta InventarioBicicleta { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _inventarioRepository.Insertar(InventarioBicicleta);

            return RedirectToPage("./InventarioBicicletas");

        }
    }
}
