using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TiendaBicicleta.Data.Interfaz;
using TiendaBicicleta.Models;

namespace TiendaBicicleta.Data.Repositorios
{
    public class InventarioBicicletaRepository : Repository<InventarioBicicleta>, IInventarioBicicletaRepository
    {
        private readonly AplicacionDbContext _db;
        public InventarioBicicletaRepository(AplicacionDbContext db): base(db)
        {

        }

        public void BorrarModelo()
        {
            var Modelos = _db.InventarioBicicletas.Where(c => c.Modelo == "F2").ToList();
            _db.RemoveRange(Modelos);
            _db.SaveChanges();
        }
    }
}