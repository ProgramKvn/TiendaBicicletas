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
    public class EditarInventarioModel : PageModel
    {
        private readonly IInventarioBicicletaRepository _inventarioRepository;

        public EditarInventarioModel(IInventarioBicicletaRepository inventarioRepository)
        {
            _inventarioRepository = inventarioRepository;
        }
        [BindProperty]
        public InventarioBicicleta InventarioBicicleta { get; set; }
        public IActionResult OnGet(int Id)
        {
            InventarioBicicleta = _inventarioRepository.GetById(Id);
            if (InventarioBicicleta == null)
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
            var ActualizarInventario = _inventarioRepository.GetById(Id);
            if (ActualizarInventario == null)
                return NotFound();

            ActualizarInventario.Modelo = InventarioBicicleta.Modelo;
            ActualizarInventario.Precio = InventarioBicicleta.Precio;
            ActualizarInventario.Color = InventarioBicicleta.Color;

            _inventarioRepository.Actualizar(ActualizarInventario);

            return RedirectToPage("./InventarioBicicletas");
        }
    }
}
