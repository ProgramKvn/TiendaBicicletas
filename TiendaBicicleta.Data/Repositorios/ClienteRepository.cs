using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TiendaBicicleta.Data.Interfaz;
using TiendaBicicleta.Models;

namespace TiendaBicicleta.Data.Repositorios
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly AplicacionDbContext _db;
        public ClienteRepository(AplicacionDbContext db): base(db)
        {
        }
            public void BorrarPorApellidos()
            {
            var Clientes = _db.Clientes.Where(m => m.Nombres == "Adolfo").ToList();
                _db.RemoveRange(Clientes);
                _db.SaveChanges();
            }
    }
}
