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
    public class EliminarRegistroClienteModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;

        public EliminarRegistroClienteModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [BindProperty]
        public Cliente Cliente { get; set; }
        public IActionResult OnPost(int Id)
        {
            var RegistroSeleccionado = _clienteRepository.GetById(Id);
            if (RegistroSeleccionado == null)
                return NotFound();

            _clienteRepository.Borrar(RegistroSeleccionado);
            return RedirectToPage("/Clientes/Cliente");
        }
    }
}