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
    public class InventarioBicicletasModel : PageModel
    {
        private readonly IInventarioBicicletaRepository _inventarioRepository;

        public InventarioBicicletasModel(IInventarioBicicletaRepository inventarioRepository)
        {
            _inventarioRepository = inventarioRepository;
        }
        [BindProperty]
        public IEnumerable<InventarioBicicleta> InventarioBicicletas { get; set; }
        public IActionResult OnGet()
        {
            InventarioBicicletas = _inventarioRepository.List();
            return Page();
        }
    }
}
