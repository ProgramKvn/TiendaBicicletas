using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TiendaBicicleta.Models;

namespace TiendaBicicleta.Data
{
    public class AplicacionDbContext : DbContext
    {
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options): base(options)
        {

        }
        public DbSet<InventarioBicicleta> InventarioBicicletas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<RegistroVenta> RegistroVentas { get; set; }
        public IEnumerable<object> Cliente { get; internal set; }
    }
}
