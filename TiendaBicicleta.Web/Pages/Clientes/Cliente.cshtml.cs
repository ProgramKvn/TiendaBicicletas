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
    public class ClienteModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        [BindProperty]
        public IEnumerable<Cliente> Clientes { get; set; }
        public IActionResult OnGet()
        {
            Clientes = _clienteRepository.List();
            return Page();
        }
    }
}
