﻿using System;
using System.Collections.Generic;
using System.Text;
using TiendaBicicleta.Models;

namespace TiendaBicicleta.Data.Interfaz
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        void BorrarPorApellidos();
    }
}
