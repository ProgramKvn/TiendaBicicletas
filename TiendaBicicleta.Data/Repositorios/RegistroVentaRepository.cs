using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TiendaBicicleta.Data.Interfaz;
using TiendaBicicleta.Models;

namespace TiendaBicicleta.Data.Repositorios
{
    public class RegistroVentaRepository : Repository<RegistroVenta>, IRegistroVentaRepository
    {
        private readonly AplicacionDbContext _db;
        public RegistroVentaRepository(AplicacionDbContext db): base(db)
        {
        }
        public void BorrarVenta()
        {
            var Ventas = _db.RegistroVentas.Where(c => c.ClienteId == 3).ToList();
            _db.RemoveRange(Ventas);
            _db.SaveChanges();
        }
    }
}
