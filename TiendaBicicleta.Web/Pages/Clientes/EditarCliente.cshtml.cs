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
    public class EditarClienteModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;

        public EditarClienteModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        [BindProperty]
        public Cliente Cliente { get; set; }
        public IActionResult OnGet(int Id)
        {
            Cliente = _clienteRepository.GetById(Id);
            if (Cliente == null)
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
            var ActualizarCliente = _clienteRepository.GetById(Id);
            if (ActualizarCliente == null)
                return NotFound();

            ActualizarCliente.Nombres = Cliente.Nombres;
            ActualizarCliente.Apellidos = Cliente.Apellidos;
            ActualizarCliente.Telefono = Cliente.Telefono;

            _clienteRepository.Actualizar(ActualizarCliente);

            return RedirectToPage("/Clientes/Cliente");
        }
    }
}
