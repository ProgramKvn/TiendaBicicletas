using System;
using System.Collections.Generic;
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
    }
}
