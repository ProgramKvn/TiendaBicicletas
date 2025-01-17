using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TiendaBicicleta.Data.Interfaz;
using TiendaBicicleta.Models;

namespace TiendaBicicleta.Web.Pages.Clientes
{
    public class RegistrarClienteModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;

        public RegistrarClienteModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        [BindProperty]
        public Cliente Cliente { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _clienteRepository.Insertar(Cliente);
            return RedirectToPage("/Clientes/Cliente");
        }

    }
}
